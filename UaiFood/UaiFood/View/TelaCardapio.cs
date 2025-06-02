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

                if (produto.getImagem() != null)
                {
                    pictureBox.Image = imgController.ExibirImage(produto.getImagem());
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
                    var produtoSelecionado = pic?.Tag as Produto;

                    if (produtoSelecionado == null)
                    {
                        MessageBox.Show("Produto não encontrado!");
                        return;
                    }

                    try
                    {
                        var userId = IdController.GetIdUser();
                        // Se não der erro, é porque é usuário logado.
                        TelaExibirProduto tela = new TelaExibirProduto(produtoSelecionado.getId());
                        tela.Show();
                        this.Close();
                    }
                    catch (InvalidOperationException)
                    {
                        // Se der erro, tenta o establishment
                        try
                        {
                            var establishmentId = IdController.GetIdEstablishment();
                            TelaEditarProduto telaEditar = new TelaEditarProduto(produtoSelecionado.getId());
                            telaEditar.Show();
                            this.Close();
                        }
                        catch (InvalidOperationException)
                        {
                            MessageBox.Show("Nenhum usuário logado!");
                        }
                    }
                };

                Label nomeLabel = new Label();
                nomeLabel.Text = produto.getNome();
                nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                nomeLabel.Dock = DockStyle.Bottom;
                nomeLabel.Font = new Font("Segoe UI", 12, FontStyle.Regular);

                Label precoLabel = new Label();
                precoLabel.Text = "R$ " + produto.getPreco().ToString("F2");
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = IdController.GetIdUser();
                // Se não der erro, é porque é usuário logado.
                TelaPrincipalCliente tela = new TelaPrincipalCliente();
                tela.Show();
                this.Close();
            }
            catch (InvalidOperationException)
            {
                // Se der erro, tenta o establishment
                try
                {
                    var establishmentId = IdController.GetIdEstablishment();
                    TelaPrincipalRestaurante tela = new TelaPrincipalRestaurante();
                    tela.Show();
                    this.Close();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Nenhum usuário logado!");
                }
            }

        }
    }
}
