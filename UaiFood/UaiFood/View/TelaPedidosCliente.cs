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
    public partial class TelaPedidosCliente : Form
    {
        BancoDados bd = new BancoDados();
        decimal total = 0;
        int itens = 0;

        public TelaPedidosCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
            telaPrincipalCliente.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCarrinho telaCarrinho = new TelaCarrinho();
            telaCarrinho.Show();
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

        private async void TelaPedidosCliente_Load(object sender, EventArgs e)
        {
            flowPanelPedidos.Controls.Clear();

            var pedidos = bd.ListarPedidosCliente(IdController.GetIdUser());

            total = 0;
            itens = 0;

            var emPreparo = pedidos.Where(p => p.getStatus().Equals("Em preparo", StringComparison.OrdinalIgnoreCase)).ToList();
            var outros = pedidos.Where(p => !p.getStatus().Equals("Em preparo", StringComparison.OrdinalIgnoreCase))
                                .OrderByDescending(p => p.getDataPedido())
                                .ToList();
            DateTime agora = DateTime.Now;

            // Filtra pedidos do usuário com status "Em preparo" feitos nos últimos 30 segundos
            var pedidosRecentes = pedidos
                .Where(p => p.getStatus().Equals("Em preparo", StringComparison.OrdinalIgnoreCase)
                            && (agora - p.getDataPedido()).TotalSeconds <= 30)
                .ToList();

            if (pedidosRecentes.Any())
            {
                long? chatId = bd.BuscarChatIdPorUserId(IdController.GetIdUser());

                if (chatId.HasValue)
                {
                    foreach (var pedidoRecente in pedidosRecentes)
                    {
                        string status = pedidoRecente.getStatus(); // "Em preparo"
                                                                   // Envia a mensagem pelo método que criamos para status
                        await TelegramController.EnviarStatusPedidoAsync(chatId.Value, status);
                    }
                }
            }

            var pedidosOrdenados = emPreparo.Concat(outros).ToList();

            foreach (var pedido in pedidosOrdenados)
            {
                var item = bd.ConsultarProdutoPorId(pedido.getIdProduto());
                var restaurante = bd.findEstablishmentById(pedido.getIdRestaurante());
                DateTime dataHoraPedido = pedido.getDataPedido();

                decimal precoUnitario = item.getPreco();
                int quantidade = pedido.getQuantidade();
                decimal totalProduto = precoUnitario * quantidade;

                Panel itemPanel = new Panel
                {
                    Width = 800,
                    Height = 140,
                    Margin = new Padding(10),
                    BackColor = Color.WhiteSmoke,
                    BorderStyle = BorderStyle.FixedSingle
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

                Label restauranteLabel = new Label
                {
                    Text = restaurante.getNome(),
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Location = new Point(100, 35),
                    AutoSize = true
                };

                Label dataHoraLabel = new Label
                {
                    Text = dataHoraPedido.ToString("dd/MM/yyyy HH:mm"),
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.Gray,
                    Location = new Point(100, 55),
                    AutoSize = true
                };

                Label precoUnitarioLabel = new Label
                {
                    Text = $"Preço: {precoUnitario:C}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(100, 75),
                    AutoSize = true
                };

                Label quantidadeLabel = new Label
                {
                    Text = $"Qtd: {quantidade}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(200, 75),
                    AutoSize = true
                };

                Label statusLabel = new Label
                {
                    Text = pedido.getStatus(),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(680, 20),
                    AutoSize = true
                };

                switch (pedido.getStatus().ToLower())
                {
                    case "em preparo":
                        statusLabel.ForeColor = Color.Orange;
                        break;
                    case "entregue":
                        statusLabel.ForeColor = Color.ForestGreen;
                        break;
                    default:
                        statusLabel.ForeColor = Color.Gray;
                        break;
                }

                Label totalProdutoLabel = new Label
                {
                    Text = $"Total: {totalProduto:C}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.ForestGreen,
                    Location = new Point(680, 45),
                    AutoSize = true
                };

                itens += quantidade;
                total += totalProduto;

                itemPanel.Controls.Add(foto);
                itemPanel.Controls.Add(nomeLabel);
                itemPanel.Controls.Add(restauranteLabel);
                itemPanel.Controls.Add(dataHoraLabel);
                itemPanel.Controls.Add(precoUnitarioLabel);
                itemPanel.Controls.Add(quantidadeLabel);
                itemPanel.Controls.Add(statusLabel);
                itemPanel.Controls.Add(totalProdutoLabel);

                flowPanelPedidos.Controls.Add(itemPanel);
            }

            lblItens.Text = itens.ToString();
            lblTotal.Text = total.ToString("C");
        }

        private void flowPanelPedidos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
