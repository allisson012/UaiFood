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
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string repeteSenha = txtRepeteSenha.Text;
            PasswordController passwordController = new PasswordController();
           // if(!passwordController.VerificarSenha(senha)
            if (senha.Equals(repeteSenha) && !String.IsNullOrEmpty(email))
            {
                UserController uc = new UserController();
                uc.createUser(email, senha);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("senha ou email invalido");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }
    }
}
