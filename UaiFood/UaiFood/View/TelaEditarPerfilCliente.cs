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
    public partial class TelaEditarPerfilCliente : Form
    {
        int? clienteLogado = IdController.GetIdUser();
        public TelaEditarPerfilCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
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

        private void TelaEditarPerfilCliente_Load(object sender, EventArgs e)
        {
            if (clienteLogado.HasValue)
            {
                BancoDados bd = new BancoDados();
                var client = bd.findUserById(clienteLogado.Value);
                txtNome.Text = client.getNome();
                txtTelefone.Text = client.getTelefone();

                ImageController imageController = new ImageController();
                picturePerfil.Image = imageController.ExibirImage(client.getPhoto());

            }
            else
            {
                MessageBox.Show("Nenhum usuário logado");
            }
        }
    }
}
