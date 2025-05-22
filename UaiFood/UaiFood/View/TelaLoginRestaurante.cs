using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaLoginRestaurante : Form
    {
        public TelaLoginRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroRestaurante telaCadastroRestaurante = new TelaCadastroRestaurante();
            telaCadastroRestaurante.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cnpj = txtCNPJ.Text;
            cnpj = Regex.Replace(cnpj, @"[^\d]", "");
            string senha = txtSenha.Text;
            if(!String.IsNullOrEmpty(cnpj) && !String.IsNullOrEmpty(senha))
            {
                var establishmentController = new EstablishmentController();
                bool loginValido = establishmentController.loginEstablishment(cnpj, senha);
                if (loginValido)
                {
                    var telaPrincipalRestaurante = new TelaPrincipalRestaurante();
                    telaPrincipalRestaurante.Show();
                    this.Close();
                    // tela errada esta faltando a tela principal restaurante
                }
            }
        }
    }
}
