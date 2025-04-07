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
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            Boolean t = userController.createUser("allisson@gmail.com", "1234");
            System.Diagnostics.Debug.WriteLine(t);
        }
    }
}
