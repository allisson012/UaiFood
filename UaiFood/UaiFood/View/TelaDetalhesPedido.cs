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
    public partial class TelaDetalhesPedido : Form
    {
        int idPedido;
        BancoDados bd = new BancoDados();
        ImageController img = new ImageController();
        public TelaDetalhesPedido(int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
        }

        private void TelaDetalhesPedido_Load(object sender, EventArgs e)
        {
            var pedido = bd.FindPedidoById(idPedido);
            var item = bd.ConsultarProdutoPorId(pedido.getIdProduto());
            var user = bd.findUserById(pedido.getIdCliente());
            var userAdress = user.getAddress();

            lblQuantidade.Text = pedido.getQuantidade().ToString();
            lblPagamento.Text = pedido.getPagamento().getTipo();
            lblValor.Text = item.getPreco().ToString("C");
            decimal valorTotal = pedido.getQuantidade() * item.getPreco();
            lblTotal.Text = valorTotal.ToString("C");
            pictureBoxProduto.Image = img.ExibirImage(item.getImagem());

            lblNome.Text = user.getNome();
            string telefone = user.getTelefone();
            telefone = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
            lblTelefone.Text = telefone;
            string cep = userAdress.getCep();
            cep = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
            lblCep.Text = cep;
            lblCidade.Text = userAdress.getCity();
            lblNumero.Text = userAdress.getNumberAddress();
            lblRua.Text = userAdress.getStreet();
            pictureBoxCliente.Image = img.ExibirImage(user.getPhoto());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPedidosRestaurante telaPedidosRestaurante = new TelaPedidosRestaurante();
            telaPedidosRestaurante.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPedidosRestaurante telaPedidosRestaurante = new TelaPedidosRestaurante();
            telaPedidosRestaurante.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pedido = bd.FindPedidoById(idPedido);
            var restaurante = bd.findEstablishmentById(pedido.getIdRestaurante());

            TelaCardapio telaCardapio = new TelaCardapio(restaurante.getId());
            telaCardapio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPrincipalRestaurante telaPrincipalRestaurante = new TelaPrincipalRestaurante();
            telaPrincipalRestaurante.Show();
            this.Close();
        }
    }
}
