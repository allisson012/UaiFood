using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.Controller;
using UaiFood.Model;

namespace UaiFood.View
{
    public partial class TelaPagamento : Form
    {
        public TelaPagamento()
        {
            InitializeComponent();
        }

        private void TelaPagamento_Load(object sender, EventArgs e)
        {
            var produtos = CarrinhoControllerStatic.getInstance().getProdutos();
            int totalItens = produtos.Sum(p => p.getQuantidade());
            decimal valorTotal = produtos.Sum(p => p.getPreco() * p.getQuantidade());

            lblItens.Text = $"{totalItens}";
            lblTotal.Text = $"{valorTotal:F2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCarrinho telaCarrinho = new TelaCarrinho();
            telaCarrinho.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tipoPagamento = "";
            bool retorno = false;
            if (opCartao.Checked)
            {
                tipoPagamento = "Cartão";
            }
            else if (opDinheiro.Checked)
            {
                tipoPagamento = "Dinheiro";
            }
            else if (opPix.Checked)
            {
                tipoPagamento = "Pix";
            }
            else
            {
                MessageBox.Show("Selecione um meio de pagamento");
            }
            if (!String.IsNullOrEmpty(tipoPagamento))
            {
                var carrinho = CarrinhoControllerStatic.getInstance();
                var produtos = carrinho.getProdutos();

                PedidoController pedidoController = new PedidoController();
                int userId = IdController.GetIdUser();

                int i = 0;
                while (i < produtos.Count)
                {
                    Produto produto = produtos[i];
                    decimal total = produto.getPreco() * produto.getQuantidade();
                    retorno = pedidoController.RegistrarPedido(
                        produto.getId(),
                        userId,
                        produto.getIdCardapio(),
                        total,
                        tipoPagamento,
                        produto.getQuantidade()
                    );
                    i++;
                }
            }
            if(retorno)
            {
                MessageBox.Show("Pedido realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao realizar pedido!");
            }
        }
    }
}
