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
    public partial class TelaPerfilCliente : Form
    {
        int? clienteLogado = IdController.GetIdUser();

        public TelaPerfilCliente()
        {
            InitializeComponent();
        }

        private void TelaPerfilCliente_Load(object sender, EventArgs e)
        {
            if (clienteLogado.HasValue)
            {
                BancoDados bd = new BancoDados();
                var client = bd.findUserById(clienteLogado.Value);
                lblNome.Text = client.getNome();
                lblTelefone.Text = client.getTelefone();

                ImageController imageController = new ImageController();
                picturePerfil.Image = imageController.ExibirImage(client.getPhoto());

            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {

        }
    }
}
