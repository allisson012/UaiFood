using System.Windows.Forms;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;
using UaiFood.View;

namespace UaiFood
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLoginRestaurante telaLoginRestaurante = new TelaLoginRestaurante();
            telaLoginRestaurante.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (!String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(senha))
            {
                var userController = new UserController();
                userController.UserLogin(email, senha);
            }
            else
            {
                MessageBox.Show("preencha os campos de email e senha");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string codigo = CodigoController.GerarCodigoNumerico();
            string destinatario = txtEmail.Text;
            EmailController emailController = new EmailController();
            Boolean emailValid = emailController.ValidarEmail(destinatario);
            EmailSender emailSender = new EmailSender();
            if (destinatario != null && !string.IsNullOrEmpty(destinatario) && emailValid)
            {
                if (emailSender.EnviarEmail(destinatario, codigo))
                {
                    MessageBox.Show("Código de recuperação enviado com sucesso");
                    TelaRecuperacaoDeConta telaRecuperacaoDeConta = new TelaRecuperacaoDeConta(codigo, destinatario);
                    telaRecuperacaoDeConta.Show();
                }
            }
            else
            {
                MessageBox.Show("Digite um email");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
