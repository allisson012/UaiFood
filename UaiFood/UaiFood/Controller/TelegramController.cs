using System.Collections.Concurrent;
using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;

namespace UaiFood.Controller
{
    public static class TelegramController
    {
        private static readonly string Token = "TOKEN-DA-API";
        private static TelegramBotClient botClient;

        private static ConcurrentDictionary<long, string> estados = new ConcurrentDictionary<long, string>();
        private static ConcurrentDictionary<long, string> cpfsRecebidos = new ConcurrentDictionary<long, string>();

        public static async Task RunBotAsync()
        {
            botClient = new TelegramBotClient(Token);

            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>() // Recebe tudo
            };

            using var cts = new CancellationTokenSource();

            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cts.Token
            );

            var me = await botClient.GetMeAsync();
            Debug.WriteLine($"Bot iniciado: @{me.Username}");

            // Mantém a task viva
            await Task.Delay(-1);
        }

        public static async Task EnviarStatusPedidoAsync(long chatId, string status)
        {
            if (botClient == null)
            {
                botClient = new TelegramBotClient(Token);
            }

            string mensagem = status.ToLower() switch
            {
                "em preparo" => "✅ Pedido confirmado!\n👨‍🍳 Estamos preparando com carinho pra você!",
                "saiu para entrega" => "📦 Partiu entrega!\n🛵 Seu pedido tá a caminho, segura aí!",
                "entregue" => "🍽️ Pedido entregue!\n😋 Bom apetite e aproveite!",
                _ => "🤔 Ops! Não conseguimos identificar o status do seu pedido."
            };
            try
            {
                await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: mensagem
                );
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Erro ao enviar mensagem para chatId {chatId}: {ex.Message}");
            }
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is not { } message) return;
            if (message.Text is not { } messageText) return;

            long chatId = message.Chat.Id;
            Debug.WriteLine($"Recebi de {chatId}: {messageText}");

            if (messageText.StartsWith("/start"))
            {
                estados[chatId] = "aguardando_cpf";
                await botClient.SendTextMessageAsync(
                    chatId,
                    "Digite o CPF cadastrado no app para receber atualizações.",
                    cancellationToken: cancellationToken
                );
                return;
            }

            if (estados.TryGetValue(chatId, out string estadoAtual))
            {
                if (estadoAtual == "aguardando_cpf")
                {
                    string cpf = messageText.Trim();
                    cpf = cpf.Replace(".", "").Replace("-", "");

                    // Validação simples do CPF (só números e 11 dígitos)
                    if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                    {
                        await botClient.SendTextMessageAsync(
                            chatId,
                            "CPF inválido. Digite um CPF válido com 11 números.",
                            cancellationToken: cancellationToken
                        );
                        return;
                    }

                    cpfsRecebidos[chatId] = cpf;
                    estados[chatId] = "confirma_cpf";

                    await botClient.SendTextMessageAsync(
                        chatId,
                        $"Você digitou o CPF: {cpf}\nDigite 'Confirmar' para confirmar ou 'Editar' para enviar novamente.",
                        cancellationToken: cancellationToken
                    );
                    return;
                }
                else if (estadoAtual == "confirma_cpf")
                {
                    if (messageText.Equals("Confirmar", StringComparison.OrdinalIgnoreCase))
                    {
                        string cpfConfirmado = cpfsRecebidos[chatId];
                        estados[chatId] = "finalizado";

                        int? userId = BuscarIdPorCpf(cpfConfirmado);

                        Debug.WriteLine($"Usuário {chatId} confirmou CPF: {cpfConfirmado} e tem ID: {userId}");

                        if (userId.HasValue)
                        {
                            BancoDados bancoDados = new BancoDados();
                            bancoDados.RegistrarChatId(userId.Value, chatId);
                        }

                        await botClient.SendTextMessageAsync(
                            chatId,
                            "CPF confirmado! Você receberá atualizações em breve.",
                            cancellationToken: cancellationToken
                        );
                        return;
                    }

                    else if (messageText.Equals("Editar", StringComparison.OrdinalIgnoreCase))
                    {
                        estados[chatId] = "aguardando_cpf";
                        await botClient.SendTextMessageAsync(
                            chatId,
                            "Ok, por favor digite novamente o CPF cadastrado no app.",
                            cancellationToken: cancellationToken
                        );
                        return;
                    }
                    else
                    {
                        await botClient.SendTextMessageAsync(
                            chatId,
                            "Por favor, responda com 'Confirmar' ou 'Editar'.",
                            cancellationToken: cancellationToken
                        );
                        return;
                    }
                }
                else
                {
                    await botClient.SendTextMessageAsync(
                        chatId,
                        "Para reiniciar o processo, digite /start.",
                        cancellationToken: cancellationToken
                    );
                    return;
                }
            }
            else
            {
                await botClient.SendTextMessageAsync(
                    chatId,
                    "Por favor, digite /start para iniciar.",
                    cancellationToken: cancellationToken
                );
            }
        }

        private static int? BuscarIdPorCpf(string cpf)
        {
            BancoDados bancoDados = new BancoDados();
            int? id = bancoDados.FindUserIdByCPF(cpf);
            if (id.HasValue)
            {
                System.Diagnostics.Debug.WriteLine($"ID do usuário = {id.Value}");
                return id;
            }
            else
            {
                return null;
            }
        }


        private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Erro: {exception.Message}");
            return Task.CompletedTask;
        }
    }
}