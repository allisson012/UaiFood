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

            if (!String.IsNullOrEmpty(restaurantName) && !String.IsNullOrEmpty(email) && !String.IsNullOrEmpty(street) && !String.IsNullOrEmpty(state) && !String.IsNullOrEmpty(state) && !String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(cep) && !String.IsNullOrEmpty(telephone) && !String.IsNullOrEmpty(numberAdress))
            {
                var establishmentController = new EstablishmentController();
                establishmentController.createPerfilEstablishment(restaurantName, email, street, state, city, cep, telephone, numberAdress);
            }
            //MessageBox.Show("Insira um email válido!");

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
