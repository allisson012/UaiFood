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
    public partial class TelaEditarProduto : Form
    {
        int idProduto;
        BancoDados bd = new BancoDados();   
        ImageController imageController = new ImageController();
        public TelaEditarProduto(int idProduto)
        {
            InitializeComponent();
            this.idProduto = idProduto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipalRestaurante telaPrincipalRestaurante = new TelaPrincipalRestaurante();
            telaPrincipalRestaurante.Show();
            this.Close();
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

        private void TelaEditarProduto_Load(object sender, EventArgs e)
        {
            var produto = bd.ConsultarProdutoPorId(idProduto);
            txtNome.Text = produto.getNome();
            txtPreco.Text = produto.getPreco().ToString();
            txtDescricao.Text = produto.getDescricao();
            pictureBox1.Image = imageController.ExibirImage(produto.getImagem());

        }
    }
}
