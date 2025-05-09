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
    public partial class TelaCriarPerfilRestaurante : Form
    {
        public TelaCriarPerfilRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController();
            byte[] imag = imageController.SelectImage();
            Image i = imageController.ExibirImage(imag);
            if (i != null)
            {
                picturePerfil.Image = i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string restaurantName = txtNome.Text;
            string email = txtEmail.Text;
            string street = txtRua.Text;
            string state = txtEstado.Text;
            string city = txtCidade.Text;
            string cep = txtCep.Text;
            string telephone = txtNumero.Text;
            string numberAdress = txtNumero.Text;

            EmailController emailController = new EmailController();
            if (!emailController.ValidarEmail(email))
            {
                MessageBox.Show("Insira um email válido!");
                return;
            }
        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            addressController controller = new addressController();
            var endereco = await controller.viaCepBuscaAsync(txtCep.Text);

            if (endereco != null)
            {
                txtRua.Text = endereco.Rua;
                txtCidade.Text = endereco.Cidade;
                txtEstado.Text = endereco.Estado;
            }
        }
    }
}
