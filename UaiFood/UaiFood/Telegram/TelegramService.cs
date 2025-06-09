using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using UaiFood.Model;

namespace UaiFood.Telegram
{
    public class TelegramService
    {
        private readonly TelegramBotClient botClient;

        public TelegramService(string token)
        {
            botClient = new TelegramBotClient(token);
        }

        public async Task EnviarMensagemAsync(long chatId, string mensagem)
        {
            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: mensagem
            );
        }
    }

    public class TelegramHelper
    {
        private readonly TelegramService _telegramService;

        public TelegramHelper(string tokenBot)
        {
            _telegramService = new TelegramService(tokenBot);
        }

        public async Task EnviarMensagem(/*Telegram mensagem*/)
        {
           // string texto = $"Pedido #{mensagem.IdPedido}\n" +
            //               $"Total: R${mensagem.Total}\n" +
             //              $"Status: {mensagem.Status}";

         //   if (!string.IsNullOrEmpty(mensagem.TextoFinal))
        //    {
        //        texto += $"\n{mensagem.TextoFinal}";
         //   }

         //   await _telegramService.EnviarMensagemAsync(mensagem.ChatId, texto);
        }
    }
}

