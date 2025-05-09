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
    public partial class TelaAdicionarProduto : Form
    {
        public TelaAdicionarProduto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = txtNome.Text;
            string price = txtPreco.Text;
            string description = txtDescricao.Text;
            string category = cbCategoria.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController();
            byte[] imag = imageController.SelectImage();
            Image i = imageController.ExibirImage(imag);
            if (i != null)
            {
                pictureBox1.Image = i;
            }
        }
    }
}
