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
        private int id;
        private int idCliente;
        private int idRestaurante;
        private int idProduto;
        private List<Produto> produtos;

        private decimal total { get; set; }
        // não sei como esta funcionando a forma de pagamento
        private FormaPagamento pagamento;
        private string status { get; set; }
        private DateTime tempoEntrega { get; set; }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }
        public int getIdCliente()
        {
            return this.idCliente;
        }
        public void setIdRestaurante(int idRestaurante)
        {
            this.idRestaurante = idRestaurante;
        }
        public int getIdRestaurante()
        {
            return this.idRestaurante;
        }
        public void setIdProduto(int idProduto)
        {
            this.idProduto = idProduto;
        }
        public int getIdProduto()
        {
            return this.idProduto;
        }
        public void setProdutos(List<Produto> produtos)
        {
            this.produtos = produtos;
        }
        public List<Produto> GetProdutos()
        {
            return this.produtos;
        }
        public void setTotal(decimal total)
        {
            this.total = total;
        }
        public decimal getTotal()
        {
            return this.total;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public string getStatus()
        {
            return this.status;
        }
        public void setTempoEntrega(DateTime tempoEntrega)
        {
            this.tempoEntrega = tempoEntrega;
        }
        public DateTime getTempoEntrega()
        {
            return this.tempoEntrega;
        }
        public void setPagamento(FormaPagamento pagamento)
        {
            this.pagamento = pagamento;
        }
        public FormaPagamento getPagamento()
        {
            return this.pagamento;
        }
    }
    public class FormaPagamento{
        private string tipo;
        private string subtipo;
        public FormaPagamento(string tipo, string subtipo)
        {
            this.tipo = tipo;
            this.subtipo = subtipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public void setSubTipo(string subTipo)
        {
            this.subtipo = subtipo;
        }
        public string getSubTipo()
        {
            return this.subtipo;
        }
    }
}
