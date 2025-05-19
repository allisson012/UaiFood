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
        private byte[] imagemSelecionada;
        public TelaAdicionarProduto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productName = txtNome.Text.Trim();
            string description = txtDescricao.Text.Trim();
            string category = cbCategoria.Text.Trim();

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Preencha o nome e o preço do produto.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal price))
            {
                MessageBox.Show("Preço inválido. Digite um valor numérico, como 9.99.");
                return;
            }

            ProductController productController = new ProductController();
         //   if (String.IsNullOrEmpty(productName) && String.IsNullOrEmpty(category) && String.IsNullOrEmpty(description) && price != null && imagemSelecionada != null)
         //   {
                productController.createProduct(productName, description, price, category, imagemSelecionada);
           
           // productController.createProduct(productName, description, price, category, imagemSelecionada);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController();
            imagemSelecionada = imageController.SelectImage();
            Image imagem = imageController.ExibirImage(imagemSelecionada);
            if (imagem != null)
            {
                pictureBox1.Image = imagem; // exibe na tela
            }
            else
            {
                MessageBox.Show("Não foi possível carregar a imagem.");
            }
        }

        private void TelaAdicionarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
