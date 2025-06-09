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
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaEditarPerfilRestaurante : Form
    {
        private byte[] imag;
        public TelaEditarPerfilRestaurante()
        {

            InitializeComponent();
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

            if (!String.IsNullOrEmpty(restaurantName) &&!String.IsNullOrEmpty(email) &&!String.IsNullOrEmpty(street) &&!String.IsNullOrEmpty(state) &&!String.IsNullOrEmpty(city) &&!String.IsNullOrEmpty(cep) &&!String.IsNullOrEmpty(telephone) &&!String.IsNullOrEmpty(numberAdress) &&image != null)
            {
                var establishmentController = new EstablishmentController();
                establishmentController.editarPerfilEstablishment(
                    IdController.GetIdEstablishment(), restaurantName,email,street,state,city,cep,telephone,numberAdress,image);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPrincipalRestaurante telaPrincipalRestaurante = new TelaPrincipalRestaurante();
            telaPrincipalRestaurante.Show();
            this.Close();
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {

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

        private void TelaEditarPerfilRestaurante_Load(object sender, EventArgs e)
        {
            var bd = new BancoDados();
            var establishment = bd.findEstablishmentById(IdController.GetIdEstablishment());
            txtEmail.Text = establishment.getEmail();
            txtNome.Text = establishment.getNome();
            txtTelefone.Text = establishment.getTelefone();
            txtCep.Text = establishment.getAddressEstablishment().getCep();
            txtCidade.Text = establishment.getAddressEstablishment().getCity();
            txtNumero.Text = establishment.getAddressEstablishment().getNumberAddress();
            txtEstado.Text = establishment.getAddressEstablishment().getState();
            txtRua.Text = establishment.getAddressEstablishment().getStreet();
            var imageController = new ImageController();
            picturePerfil.Image = imageController.ExibirImage(establishment.getImage());
            imag = establishment.getImage();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
