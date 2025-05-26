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
    public partial class TelaPrincipalRestaurante : Form
    {
        int? establishmentId = IdController.GetIdEstablishment();
        public TelaPrincipalRestaurante()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaAdicionarProduto telaAdicionarProduto = new TelaAdicionarProduto();
            telaAdicionarProduto.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TelaEditarProduto telaEditarProduto = new TelaEditarProduto();
            telaEditarProduto.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaEditarPerfilRestaurante telaEditarPerfilRestaurante = new TelaEditarPerfilRestaurante();
            telaEditarPerfilRestaurante.Show();
        }

        private void TelaPrincipalRestaurante_Load(object sender, EventArgs e)
        {
            BancoDados bd = new BancoDados();
            var establishment = bd.findEstablishmentById(IdController.GetIdEstablishment());
            lblNome.Text = establishment.GetNome();
            lblTelefone.Text = establishment.GetTelefone();
            var establishmentAddress = establishment.GetAddressEstablishment();
            lblCep.Text = establishmentAddress.getCep();
            lblCidade.Text = establishmentAddress.getCity();
            lblEstado.Text = establishmentAddress.getState();
            ImageController imageController = new ImageController();
            pictureBox1.Image = imageController.ExibirImage(establishment.GetImage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
