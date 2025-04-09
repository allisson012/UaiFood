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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCriarPerfilCliente telaCriarPerfilCliente = new TelaCriarPerfilCliente();
            telaCriarPerfilCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String senha = txtSenha.Text;
            String RepeteSenha = txtRepeteSenha.Text;
            if (senha.Equals(RepeteSenha))
            {
                UserController userController = new UserController();
                userController.createUser(email, senha);
            }
        }
    }
}
