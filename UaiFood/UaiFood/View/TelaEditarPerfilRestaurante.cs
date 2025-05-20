using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaEditarPerfilRestaurante : Form
    {
        public TelaEditarPerfilRestaurante()
        {
            InitializeComponent();
            var bd = new BancoDados();
            var establishment = bd.findEstablishmentById(IdController.GetIdEstablishment());
            txtEmail.Text = establishment.GetEmail();
            txtNome.Text = establishment.GetNome();
            txtTelefone.Text = establishment.GetTelefone();
            txtCep.Text = establishment.GetAddressEstablishment().getCep();
            txtCidade.Text = establishment.GetAddressEstablishment().getCity();
            txtNumero.Text = establishment.GetAddressEstablishment().getNumberAddress();
            txtEstado.Text = establishment.GetAddressEstablishment().getState();
            txtRua.Text = establishment.GetAddressEstablishment().getStreet();
            var imageController = new ImageController();
            picturePerfil.Image = imageController.ExibirImage(establishment.GetImage());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
