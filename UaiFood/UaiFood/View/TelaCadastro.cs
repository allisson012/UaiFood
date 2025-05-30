﻿using System;
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
            this.Close();
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
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                txtRepeteSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                txtRepeteSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
