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
    public partial class TelaCriarPerfilRestaurante : Form
    {
        private byte[] imag;
        public TelaCriarPerfilRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController();
            imag = imageController.SelectImage();
            Image i = imageController.ExibirImage(imag);
            if (i != null)
            {
                picturePerfil.Image = i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string restaurantName = txtNome.Text;
            byte[] image = imag;
            string email = txtEmail.Text;
            string street = txtRua.Text;
            string state = txtEstado.Text;
            string city = txtCidade.Text;
            string cep = txtCep.Text;
            cep = Regex.Replace(cep, @"[^\d]", "");
            string telephone = txtTelefone.Text;
            telephone = Regex.Replace(telephone, @"[^\d]", "");
            string numberAdress = txtNumero.Text;

            if (!String.IsNullOrEmpty(restaurantName) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(street) && !String.IsNullOrEmpty(state) && !String.IsNullOrEmpty(state) && !String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(cep) && !String.IsNullOrEmpty(telephone) && !String.IsNullOrEmpty(numberAdress) && image != null)
            {
                var establishmentController = new EstablishmentController();
                establishmentController.createPerfilEstablishment(1,restaurantName, email, street, state, city, cep, telephone, numberAdress , image);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente! ");
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

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
