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
    public partial class TelaExibirProduto : Form
    {
        int idProduto;
        public TelaExibirProduto(int idProduto)
        {
            InitializeComponent();
            this.idProduto = idProduto;
        }

        private void TelaExibirProduto_Load(object sender, EventArgs e)
        {
            BancoDados bd = new BancoDados();
            ImageController img = new ImageController();

            var produto = bd.ConsultarProdutoPorId(idProduto);
            lblNome.Text = produto.getNome();
            lblDescricao.Text = produto.getDescricao();
            lblCategoria.Text = produto.getCategoria();
            lblPreco.Text = produto.getPreco().ToString();
            pictureBox1.Image = img.ExibirImage(produto.getImagem());
            
        }
    }
}
