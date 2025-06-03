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
    }
}
