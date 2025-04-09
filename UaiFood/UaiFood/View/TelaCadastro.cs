using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLoginRestaurante telaLoginRestaurante = new TelaLoginRestaurante();
            telaLoginRestaurante.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string repeteSenha = txtRepeteSenha.Text;

            PasswordController passwordController = new PasswordController();
            EmailController emailController = new EmailController();
            if (senha == repeteSenha) {
            if (emailController.ValidarEmail(email) == true)
            {
                if (passwordController.VerificarSenha(senha) == true)
                {
                    TelaCriarPerfilCliente telaCriarPerfilCliente = new TelaCriarPerfilCliente();
                    telaCriarPerfilCliente.Show();
                }
                else
                {
                    MessageBox.Show("A senha deve conter: 1 número, 1 letra maiúscula e 1 caracter especial", "Formato de senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Email inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        }
    }
}
