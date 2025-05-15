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
    public partial class TelaCadastroRestaurante : Form
    {
        public TelaCadastroRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Close();
        }

        private void TelaCadastroRestaurante_Load(object sender, EventArgs e)
        {

        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cnpj = txtCNPJ.Text;
            cnpj = Regex.Replace(cnpj, @"[^\d]", "");

            string senha = txtSenha.Text;
            string repeteSenha = txtRepeteSenha.Text;
            if (senha.Equals(repeteSenha) && cnpj.Length == 14)
            {
                var establishmentController = new EstablishmentController();
                establishmentController.createEstablishment(cnpj, txtSenha.Text);
            }
            else
            {
                MessageBox.Show("CNPJ Inválido ou senha invalida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtRepeteSenha_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaLoginRestaurante telaLoginRestaurante = new TelaLoginRestaurante();
            telaLoginRestaurante.Show();
            this.Close();
        }

        public static implicit operator TelaCadastroRestaurante(TelaCadastro v)
        {
            throw new NotImplementedException();
        }
    }
}
