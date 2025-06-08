using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    internal class Telegram
    {
        private long ChatId;
        private int IdPedido;
        private decimal Total;
        private string Status;
        private string TextoFinal;

        public void setChatId(long chatId)
        {
            this.ChatId = chatId;
        }
        public long getChatId()
        {
            return this.ChatId;
        }
        public void setIdPedido(int idPedido)
        {
            this.IdPedido = idPedido;
        }
        public int getIdPedido()
        {
            return this.IdPedido;
        }
        public void setTotal(decimal total)
        {
            this.Total = total;
        }
        public decimal getTotal()
        {
            return this.Total;
        }
        public void setStatus(string status)
        {
            this.Status = status;
        }
        public string getStatus()
        {
            return this.Status;
        }
        public void setTextoFinal(string texto)
        {
            this.TextoFinal = texto;
        }
        public string getTextoFinal()
        {
            return this.TextoFinal;
        }
    }
}
