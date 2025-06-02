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
        BancoDados bd = new BancoDados();


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
            var establishment = bd.findEstablishmentById(IdController.GetIdEstablishment());
            MessageBox.Show("Escolha no cardápio o produto que deseja editar!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TelaCardapio telaCardapio = new TelaCardapio(establishment.getId());
            telaCardapio.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaEditarPerfilRestaurante telaEditarPerfilRestaurante = new TelaEditarPerfilRestaurante();
            telaEditarPerfilRestaurante.Show();
        }

        private void TelaPrincipalRestaurante_Load(object sender, EventArgs e)
        {
            var establishment = bd.findEstablishmentById(IdController.GetIdEstablishment());
            lblNome.Text = establishment.getNome();
            lblTelefone.Text = establishment.getTelefone();
            var establishmentAddress = establishment.getAddressEstablishment();
            lblCep.Text = establishmentAddress.getCep();
            lblCidade.Text = establishmentAddress.getCity();
            lblEstado.Text = establishmentAddress.getState();
            ImageController imageController = new ImageController();
            pictureBox1.Image = imageController.ExibirImage(establishment.getImage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCardapio telaCardapio = new TelaCardapio(IdController.GetIdEstablishment());
            telaCardapio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "Tem certeza de que deseja deletar sua conta?",
       "Confirmação",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
   );

            if (resultado == DialogResult.Yes)
            {
                EstablishmentController establishmentController = new EstablishmentController();
                bool deletado = establishmentController.deleteEstablishment();
                if (deletado)
                {
                    MessageBox.Show("Conta deletado com sucesso");
                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();
                    this.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var establishment = bd.findEstablishmentById(IdController.GetIdEstablishment());
            MessageBox.Show("Escolha no cardápio o produto que deseja excluir!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TelaCardapio telaCardapio = new TelaCardapio(establishment.getId());
            telaCardapio.Show();
            this.Close();
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnOpcoes, new Point(0, btnOpcoes.Height));
        }

        private void sairDaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair da conta?",
                                          "Sair",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                TelaLoginRestaurante telaLogin = new TelaLoginRestaurante();
                telaLogin.Show();
                this.Close();
                IdController.LogOffEstablishment();
            }
        }
    }
}
