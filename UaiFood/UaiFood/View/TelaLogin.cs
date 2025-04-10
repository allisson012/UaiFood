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

            PasswordController passwordController = new PasswordController();
            EmailController emailController = new EmailController();
            if (emailController.ValidarEmail(email) == true)
            {
                TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
                telaPrincipalCliente.Show();

            }
            else
            {
                MessageBox.Show("Email inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //PasswordController p = new PasswordController();
            // p.VerificarSenha("Allisson21#");
            TelaCriarPerfilCliente telaCriarPerfilCliente = new TelaCriarPerfilCliente();
            telaCriarPerfilCliente.Show();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var loginController = new LoginGoogleController();
                var credential = await loginController.FazerLoginGoogleAsync();

                if (credential != null && credential.Token != null)
                {
                    MessageBox.Show("Login com Google bem-sucedido!");

                    // Exemplo: acessar o e-mail do usuário
                    // Você pode usar a biblioteca Google.Apis.Oauth2 para pegar info detalhada se quiser
                    // var email = credential.UserId; // depende do fluxo de escopo usado
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao realizar o login com Google.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fazer login com Google: {ex.Message}");
            }
        }
    }
}
