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
    public partial class TelaPerfilCliente : Form
    {
        int? clienteLogado = IdController.GetIdUser();

        public TelaPerfilCliente()
        {
            InitializeComponent();
        }

        private void TelaPerfilCliente_Load(object sender, EventArgs e)
        {
            if (clienteLogado.HasValue)
            {
                BancoDados bd = new BancoDados();
                var client = bd.findUserById(clienteLogado.Value);
                lblNome.Text = client.getNome();
                lblTelefone.Text = client.getTelefone();
                var address = client.getAddress();
                lblCep.Text = address.getCep();
                lblCidade.Text = address.getCity();
                lblEstado.Text = address.getState();
                lblRua.Text = address.getStreet();
                lblNumero.Text = address.getNumberAddress();


                ImageController imageController = new ImageController();
                picturePerfil.Image = imageController.ExibirImage(client.getPhoto());

            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            TelaEditarPerfilCliente telaEditarPerfilCliente = new TelaEditarPerfilCliente();
            telaEditarPerfilCliente.Show();
        }

        private void btnExcluirPefil_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
"Tem certeza de que deseja deletar sua conta?",
"Confirmação",
MessageBoxButtons.YesNo,
MessageBoxIcon.Warning
);

            if (resultado == DialogResult.Yes)
            {
                UserController userController = new UserController();
                bool deletado = userController.deleteUser();
                if (deletado)
                {
                    MessageBox.Show("Conta deletado com sucesso");
                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                TelaLogin telaLogin = new TelaLogin();
                telaLogin.Show();
                this.Close();
                IdController.LogOffUser();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaCarrinho telaCarrinho = new TelaCarrinho();
            telaCarrinho.Show();
            this.Close();
        }
    }
}
