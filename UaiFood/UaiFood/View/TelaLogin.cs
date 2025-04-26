using System.Windows.Forms;
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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            var userController = new UserController();
            userController.UserLogin(email, senha);

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
            if(destinatario != null && !string.IsNullOrEmpty(destinatario) && emailValid){
                if (emailSender.EnviarEmail(destinatario, codigo))
                {
                    MessageBox.Show("Código de recuperação enviado com sucesso");
                    TelaRecuperacaoDeConta telaRecuperacaoDeConta = new TelaRecuperacaoDeConta();
                    telaRecuperacaoDeConta.Show();
                }
            }
            else
            {
                MessageBox.Show("Digite um email");
            }
          
        }
    }
}
