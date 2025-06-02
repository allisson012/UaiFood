using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;
using UaiFood.Model;

namespace UaiFood.View
{
    public partial class TelaEditarProduto : Form
    {
        private int idProduto;
        private byte[] imagemSelecionada;
        BancoDados bd = new BancoDados();
        ImageController imageController = new ImageController();
        
        public TelaEditarProduto(int idProduto)
        {
            InitializeComponent();
            this.idProduto = idProduto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? establishmentId = IdController.GetIdEstablishment();
            TelaCardapio telaCardapio = new TelaCardapio(establishmentId.Value);
            telaCardapio.Show();
            this.Close();
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

        private void TelaEditarProduto_Load(object sender, EventArgs e)
        {
            var produto = bd.ConsultarProdutoPorId(idProduto);
            txtNome.Text = produto.getNome();
            txtPreco.Text = produto.getPreco().ToString();
            txtDescricao.Text = produto.getDescricao();
            cbCategoria.Text = produto.getCategoria();
            imagemSelecionada = produto.getImagem();
            pictureBox1.Image = imageController.ExibirImage(produto.getImagem());           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPreco.Text, out decimal price))
            {
                MessageBox.Show("Preço inválido. Digite um valor numérico, como 9.99.");
                return;
            }
            
            ProductController productController = new ProductController();
            productController.updateProduct(idProduto, txtNome.Text, txtDescricao.Text, price, cbCategoria.Text, imagemSelecionada);


        }
    }
}
