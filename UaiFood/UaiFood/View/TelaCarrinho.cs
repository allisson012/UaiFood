using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaCarrinho : Form
    {
        public TelaCarrinho()
        {
            InitializeComponent();
        }

        private void TelaCarrinho_Load(object sender, EventArgs e)
        {
            AtualizarTela();
            AtualizarResumo();
        }

        private void AtualizarTela()
        {
            flowPanelCarrinho.Controls.Clear();

            var produtos = CarrinhoControllerStatic.getInstance().getProdutos();

            var produtosAgrupados = produtos
                .GroupBy(p => p.getId())
                .Select(g => new
                {
                    Produto = g.First(),
                    QuantidadeTotal = g.Sum(p => p.getQuantidade())
                });

            foreach (var grupo in produtosAgrupados)
            {
                var item = grupo.Produto;

                Panel itemPanel = new Panel
                {
                    Width = 800,
                    Height = 100,
                    Margin = new Padding(10),
                    BackColor = Color.WhiteSmoke
                };

                PictureBox foto = new PictureBox
                {
                    Size = new Size(80, 80),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                ImageController imgController = new ImageController();

                if (item.getImagem() != null)
                {
                    foto.Image = imgController.ExibirImage(item.getImagem());
                }
                else
                {
                    foto.Image = Properties.Resources.comida;
                }

                Label nomeLabel = new Label
                {
                    Text = item.getNome(),
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(100, 10),
                    AutoSize = true
                };

                Button btnMenos = new Button
                {
                    Text = "-",
                    Size = new Size(30, 30),
                    Location = new Point(520, 35),
                    Tag = item
                };

                Label qtdLabel = new Label
                {
                    Text = grupo.QuantidadeTotal.ToString(),
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(560, 40),
                    AutoSize = true
                };

                Button btnMais = new Button
                {
                    Text = "+",
                    Size = new Size(30, 30),
                    Location = new Point(590, 35),
                    Tag = item
                };

                Label valorLabel = new Label
                {
                    Text = item.getPreco().ToString("C"),
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(690, 40),
                    AutoSize = true
                };

                // Eventos de clique
                btnMais.Click += (s, e) =>
                {
                    item.setQuantidade(item.getQuantidade() + 1);
                    AtualizarTela();
                    AtualizarResumo();
                };

                btnMenos.Click += (s, e) =>
                {
                    item.setQuantidade(item.getQuantidade() - 1);

                    if (item.getQuantidade() <= 0)
                    {
                        var resultado = MessageBox.Show(
                            "Deseja remover este produto do carrinho?",
                            "Remover Produto",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (resultado == DialogResult.Yes)
                        {
                            CarrinhoControllerStatic.getInstance().getProdutos().RemoveAll(p => p.getNome() == item.getNome());
                        }
                        else
                        {
                            item.setQuantidade(1);
                        }
                    }

                    AtualizarTela();
                    AtualizarResumo();
                };

                itemPanel.Controls.Add(foto);
                itemPanel.Controls.Add(nomeLabel);
                itemPanel.Controls.Add(btnMenos);
                itemPanel.Controls.Add(qtdLabel);
                itemPanel.Controls.Add(btnMais);
                itemPanel.Controls.Add(valorLabel);

                flowPanelCarrinho.Controls.Add(itemPanel);
            }
        }

        private void AtualizarResumo()
        {
            var produtos = CarrinhoControllerStatic.getInstance().getProdutos();
            int totalItens = produtos.Sum(p => p.getQuantidade());
            decimal valorTotal = produtos.Sum(p => p.getPreco() * p.getQuantidade());

            lblItens.Text = $"{totalItens}";
            lblTotal.Text = $"{valorTotal:F2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarrinhoControllerStatic carrinhoControllerStatic = CarrinhoControllerStatic.getInstance();
            if (carrinhoControllerStatic.getProdutos().Count != 0)
            {
                TelaPagamento telaPagamento = new TelaPagamento();
                telaPagamento.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum produto no carrinho!");
            }
            }

        private void flowPanelCarrinho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
            this.Close();

        }
    }
}
