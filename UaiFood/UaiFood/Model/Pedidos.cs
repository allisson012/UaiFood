using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    internal class Pedidos
    {
        public List<Produto> Produtos { get; set; }
        public decimal Total { get; set; }
        public FormaPagamento Pagamento {get; set;}
        public string Status { get; set; }
        public DateTime TempoEntrega { get; set; }
    }
    public class FormaPagamento{
        public string Tipo { get; set; }  
        public string Subtipo { get; set; }  
    }
}
