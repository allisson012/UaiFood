using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace UaiFood.Controller
{
    public static class TelegramController
    {
        private static readonly string Token = "8020942832:AAHxDA1lGagOswWyQaKYqknmqOemeYt1yBM";
        private static TelegramBotClient botClient;

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
            System.Diagnostics.Debug.WriteLine($"Bot iniciado: @{me.Username}");

            // Mantém a task viva
            await Task.Delay(-1);
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Message is not { } message)
                return;

            if (message.Text is not { } messageText)
                return;

            System.Diagnostics.Debug.WriteLine($"Recebi de {message.Chat.Id}: {messageText}");

            if (messageText.StartsWith("/start"))
            {
                await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Bem-vindo ao UaiFood! 🍔",
                    cancellationToken: cancellationToken
                );
            }
            else
            {
                await botClient.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: $"Você disse: {messageText}",
                    cancellationToken: cancellationToken
                );
            }
        }

        private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            System.Diagnostics.Debug.WriteLine($"Erro: {exception.Message}");
            return Task.CompletedTask;
        }
    }
}
