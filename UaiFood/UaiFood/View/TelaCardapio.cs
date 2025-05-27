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
    public partial class TelaCardapio : Form
    {
        int idEstablishment;
        int? restauranteLogado = IdController.GetIdEstablishment();
        int? usuarioLogado = IdController.GetIdUser();

        public TelaCardapio(int id)
        {
            InitializeComponent();
            this.idEstablishment = id;
        }

        private void TelaCardapio_Load(object sender, EventArgs e)
        {
            BancoDados bd = new BancoDados();
            ImageController imgController = new ImageController();
            var produtosEncontrados = bd.ConsultarProdutoPorIdCardapio(idEstablishment);
            flowPanelProdutos.Controls.Clear(); 

            foreach (var produto in produtosEncontrados)
            {
                Panel produtoPanel = new Panel();
                produtoPanel.Width = 150;
                produtoPanel.Height = 180;
                produtoPanel.Margin = new Padding(10);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 120;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                if (produto.Imagem != null)
                {
                    pictureBox.Image = imgController.ExibirImage(produto.Imagem);
                }
                else
                {
                    pictureBox.Image = Properties.Resources.comida; 
                }

                pictureBox.Tag = produto;
                pictureBox.Cursor = Cursors.Hand;

                pictureBox.Click += (s, args) =>
                {
                    var pic = s as PictureBox;
                    var produtoSelecionado = pic.Tag as Produto;
                    if (usuarioLogado.HasValue)
                    {
                        TelaExibirProduto tela = new TelaExibirProduto(produto.Id);
                        tela.Show();
                        this.Close();
                    }
                    else if (restauranteLogado.HasValue)
                    {
                        TelaEditarProduto telaEditar = new TelaEditarProduto(produto.Id);
                        telaEditar.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário logado!");
                    }
                    
                };

                Label nomeLabel = new Label();
                nomeLabel.Text = produto.Nome;
                nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                nomeLabel.Dock = DockStyle.Bottom;
                nomeLabel.Font = new Font("Segoe UI", 12, FontStyle.Regular);

                Label precoLabel = new Label();
                precoLabel.Text = "R$ " + produto.Preco.ToString("F2");
                precoLabel.TextAlign = ContentAlignment.MiddleCenter;
                precoLabel.Dock = DockStyle.Bottom;
                precoLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                produtoPanel.Controls.Add(pictureBox);
                produtoPanel.Controls.Add(precoLabel);
                produtoPanel.Controls.Add(nomeLabel);

                flowPanelProdutos.Controls.Add(produtoPanel);
            }

            if (produtosEncontrados.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado com esse nome.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
