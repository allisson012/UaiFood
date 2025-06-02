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
    public partial class TelaPesquisa : Form
    {
        int? clienteLogado = IdController.GetIdUser();

        public TelaPesquisa()
        {
            InitializeComponent();
            cbFiltro.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clienteLogado != null)
            {
                TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
                telaPrincipalCliente.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clienteLogado != null)
            {
                TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
                telaPerfilCliente.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum usuário logado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex == 0)
            {
                BancoDados bd = new BancoDados();
                var restaurantesEncontrados = bd.BuscarRestaurantes(txtPesquisa.Text);
                flowPanelProdutos.Controls.Clear(); // limpa resultados anteriores

                ImageController imgController = new ImageController();

                foreach (var restaurante in restaurantesEncontrados)
                {
                    Panel restaurantePanel = new Panel();
                    restaurantePanel.Width = 150;
                    restaurantePanel.Height = 200;
                    restaurantePanel.Margin = new Padding(10);
                    restaurantePanel.BackColor = Color.White; // opcional: cor de fundo

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = 150;
                    pictureBox.Height = 120;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    if (restaurante.getImage() != null)
                    {
                        pictureBox.Image = imgController.ExibirImage(restaurante.getImage());
                    }
                    else
                    {
                        pictureBox.Image = Properties.Resources.restaurante; // imagem padrão
                    }

                    pictureBox.Tag = restaurante;
                    pictureBox.Cursor = Cursors.Hand;

                    pictureBox.Click += (s, args) =>
                    {
                        var pic = s as PictureBox;
                        var restauranteSelecionado = pic.Tag as Establishment;
                        TelaExibirRestaurante tela = new TelaExibirRestaurante(restaurante.getId());
                        tela.Show();
                    };

                    // Label nome
                    Label nomeLabel = new Label();
                    nomeLabel.Text = restaurante.getNome();
                    nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                    nomeLabel.Dock = DockStyle.Bottom;
                    nomeLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                    // Label cidade - estado
                    Label localLabel = new Label();
                    localLabel.Text = $"{restaurante.getAddressEstablishment().getCity()} - {restaurante.getAddressEstablishment().getState()}";
                    localLabel.TextAlign = ContentAlignment.MiddleCenter;
                    localLabel.Dock = DockStyle.Bottom;
                    localLabel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    localLabel.ForeColor = Color.Gray;

                    restaurantePanel.Controls.Add(pictureBox);
                    restaurantePanel.Controls.Add(localLabel);
                    restaurantePanel.Controls.Add(nomeLabel);

                    flowPanelProdutos.Controls.Add(restaurantePanel);
                }

                if (restaurantesEncontrados.Count == 0)
                {
                    MessageBox.Show("Nenhum restaurante encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                BancoDados bd = new BancoDados();
                ImageController imgController = new ImageController();
                var produtosEncontrados = bd.BuscarTodosProdutos(txtPesquisa.Text);
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
                        var produtoSelecionado = pic.Tag as Produto;

                        TelaExibirProduto tela = new TelaExibirProduto(produto.getId());
                        tela.Show();

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
        }


        private void TelaPesquisa_Load(object sender, EventArgs e)
        {
            BancoDados bd = new BancoDados();
            var restaurantesEncontrados = bd.ExibirRestaurantes();
            flowPanelProdutos.Controls.Clear(); // limpa resultados anteriores

            ImageController imgController = new ImageController();

            foreach (var restaurante in restaurantesEncontrados)
            {
                Panel restaurantePanel = new Panel();
                restaurantePanel.Width = 150;
                restaurantePanel.Height = 200;
                restaurantePanel.Margin = new Padding(10);
                restaurantePanel.BackColor = Color.White; // opcional: cor de fundo

                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 150;
                pictureBox.Height = 120;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                if (restaurante.getImage() != null)
                {
                    pictureBox.Image = imgController.ExibirImage(restaurante.getImage());
                }
                else
                {
                    pictureBox.Image = Properties.Resources.restaurante; // imagem padrão
                }

                pictureBox.Tag = restaurante;
                pictureBox.Cursor = Cursors.Hand;

                pictureBox.Click += (s, args) =>
                {
                    var pic = s as PictureBox;
                    var restauranteSelecionado = pic.Tag as Establishment;
                    TelaExibirRestaurante tela = new TelaExibirRestaurante(restaurante.getId());
                    tela.Show();
                };

                // Label nome
                Label nomeLabel = new Label();
                nomeLabel.Text = restaurante.getNome();
                nomeLabel.TextAlign = ContentAlignment.MiddleCenter;
                nomeLabel.Dock = DockStyle.Bottom;
                nomeLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                // Label cidade - estado
                Label localLabel = new Label();
                localLabel.Text = $"{restaurante.getAddressEstablishment().getCity()} - {restaurante.getAddressEstablishment().getState()}";
                localLabel.TextAlign = ContentAlignment.MiddleCenter;
                localLabel.Dock = DockStyle.Bottom;
                localLabel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                localLabel.ForeColor = Color.Gray;

                restaurantePanel.Controls.Add(pictureBox);
                restaurantePanel.Controls.Add(localLabel);
                restaurantePanel.Controls.Add(nomeLabel);

                flowPanelProdutos.Controls.Add(restaurantePanel);
            }

            if (restaurantesEncontrados.Count == 0)
            {
                MessageBox.Show("Nenhum restaurante encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void flowPanelProdutos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

