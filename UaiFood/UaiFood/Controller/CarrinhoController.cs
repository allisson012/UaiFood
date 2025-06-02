using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Model;

namespace UaiFood.Controller
{
    internal class CarrinhoController
    {
        private Carrinho carrinho = new Carrinho();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.AdicionarProduto(produto);
            MessageBox.Show($"Produto {produto.getNome()} adicionado ao carrinho.");
        }
        public void RemoverProduto(Produto produto)
        {
            carrinho.RemoverProduto(produto);
            MessageBox.Show($"Produto {produto.getNome()} removido do carrinho");
        }
        public void MostrarCarrinho()
        {
            string mensagem = "Produtos no carrinho: \n";

            foreach(var p in carrinho.Produtos)
            {
                mensagem += $"{p.getNome()} - R${p.getPreco()}\n";
            }

            mensagem += $"Total: R${carrinho.CalcularTotal()}";
            MessageBox.Show(mensagem);
        }
        public void FinalizarCompra(string tipoPagamento, string subtipo = null)
        {
            if (tipoPagamento != "Dinheiro" && tipoPagamento != "Cartão")
            {
                MessageBox.Show("Forma de pagamento inválida. Escolha 'Dinheiro' ou 'Cartão'.");
                return;
            }

            if (tipoPagamento == "Cartão" && subtipo != "Débito" && subtipo != "Crédito")
            {
                MessageBox.Show("Para pagamento com Cartão, escolha 'Débito' ou 'Crédito'.");
                return;
            }

            var pedido = new Pedido();

            pedido.setProdutos(carrinho.Produtos.ToList());

            pedido.setTotal(carrinho.CalcularTotal());
            pedido.setPagamento(new FormaPagamento(tipoPagamento,subtipo));
            pedido.setStatus("Em preparo");
            pedido.setTempoEntrega(DateTime.Now.AddMinutes(new Random().Next(30, 91)));
            

            var banco = new BancoDados();
            banco.RegistrarPedido(pedido);

            MessageBox.Show($"Pedido Realizado com Sucesso!\n +" +
                $"Total: R${pedido.getTotal()}\n" +
                $"Pagamento: {pedido.getPagamento()}\n" +
                $"Tempo de Entrega: {pedido.getTempoEntrega().ToShortTimeString()}");

            carrinho.LimparCarrinho();
        }
    }
}
