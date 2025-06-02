using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaPrincipalCliente : Form
    {
        public TelaPrincipalCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PedidoController pedidoController = new PedidoController();
            BancoDados bd = new BancoDados();
            var produto = bd.ConsultarProdutoPorId(2);
            decimal total = produto.getPreco() * 2;
            pedidoController.RegistrarPedido(produto.getId(), IdController.GetIdUser(), produto.getIdCardapio(), total, "cartão", "Credito");
        }
    }
}
