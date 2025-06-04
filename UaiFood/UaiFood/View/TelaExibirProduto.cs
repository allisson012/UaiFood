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
using UaiFood.Model;

namespace UaiFood.View
{ 
    public partial class TelaExibirProduto : Form
    {
        int idProduto;
        Produto produto;
        private CarrinhoControllerStatic carrinhoControllerStatic;
        public TelaExibirProduto(int idProduto)
        {
            InitializeComponent();
            this.idProduto = idProduto;
        }

        private void TelaExibirProduto_Load(object sender, EventArgs e)
        {
            BancoDados bd = new BancoDados();
            ImageController img = new ImageController();

            this.produto = bd.ConsultarProdutoPorId(idProduto);
            lblNome.Text = produto.getNome();
            lblDescricao.Text = produto.getDescricao();
            lblCategoria.Text = produto.getCategoria();
            lblPreco.Text = produto.getPreco().ToString();
            pictureBox1.Image = img.ExibirImage(produto.getImagem());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("clicado");
            var bd = new BancoDados();
            var produto = bd.ConsultarProdutoPorId(idProduto);
            carrinhoControllerStatic = CarrinhoControllerStatic.getInstance();
            carrinhoControllerStatic.addProduto(produto);
            MessageBox.Show("Produto adicionado ao carrinho!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TelaExibirRestaurante telaExibirRestaurante = new TelaExibirRestaurante(produto.getIdCardapio());
            telaExibirRestaurante.Show();
            this.Close();
        }
    }
}
