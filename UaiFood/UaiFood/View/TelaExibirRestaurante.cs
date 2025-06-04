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
    public partial class TelaExibirRestaurante : Form
    {
        int idRestaurante;
        public TelaExibirRestaurante(int idRestaurante)
        {
            InitializeComponent();
            this.idRestaurante = idRestaurante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }

        private void TelaExibirRestaurante_Load(object sender, EventArgs e)
        {
            BancoDados bd = new BancoDados();
            ImageController img = new ImageController();
            var restaurante = bd.findEstablishmentById(idRestaurante);
            lblNome.Text = restaurante.getNome();
            lblTelefone.Text = restaurante.getTelefone();
            var adress = restaurante.getAddressEstablishment();
            lblNumero.Text = adress.getNumberAddress();
            lblCidade.Text = adress.getCity();
            lblEstado.Text = adress.getState();
            lblRua.Text = adress.getStreet();
            lblCep.Text = adress.getCep();
            picturePerfil.Image = img.ExibirImage(restaurante.getImage());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            BancoDados bd = new BancoDados();
            var restaurante = bd.findEstablishmentById(idRestaurante);
            TelaCardapio tela = new TelaCardapio(restaurante.getId());
            tela.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaCarrinho telaCarrinho = new TelaCarrinho();
            telaCarrinho.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TelaPedidosCliente telaPedidosCliente = new TelaPedidosCliente();
            telaPedidosCliente.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
            this.Close();
        }
    }
}
