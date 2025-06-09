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
    public partial class TelaPedidosRestaurante : Form
    {
        BancoDados bd = new BancoDados();
        decimal total = 0;
        int itens = 0;
        public TelaPedidosRestaurante()
        {
            InitializeComponent();
        }

        private void TelaPedidosRestaurante_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }
        public void CarregarPedidos()
        {
            flowPanelPedidos.Controls.Clear();

            var pedidos = bd.ListarPedidos(IdController.GetIdEstablishment());

            var naoEntregues = pedidos.Where(p => !p.getStatus().Equals("Entregue", StringComparison.OrdinalIgnoreCase))
                                      .OrderByDescending(p => p.getDataPedido())
                                      .ToList();

            var entregues = pedidos.Where(p => p.getStatus().Equals("Entregue", StringComparison.OrdinalIgnoreCase))
                                   .OrderByDescending(p => p.getDataPedido())
                                   .ToList();

            var pedidosOrdenados = naoEntregues.Concat(entregues).ToList();

            total = 0;
            itens = 0;

            foreach (var pedido in pedidosOrdenados)
            {
                var item = bd.ConsultarProdutoPorId(pedido.getIdProduto());
                var cliente = bd.findUserById(pedido.getIdCliente());

                decimal precoUnitario = item.getPreco();
                int quantidade = pedido.getQuantidade();
                decimal totalProduto = precoUnitario * quantidade;

                total += totalProduto;
                itens += quantidade;

                Panel itemPanel = new Panel
                {
                    Width = 810,
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

                Label quantidadeLabel = new Label
                {
                    Text = $"Qtd: {quantidade}",
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(100, 40),
                    AutoSize = true
                };

                Label totalProdutoLabel = new Label
                {
                    Text = $"Total: {totalProduto:C}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.ForestGreen,
                    Location = new Point(100, 65),
                    AutoSize = true
                };

                string status = pedido.getStatus();

                if (!status.Equals("Entregue", StringComparison.OrdinalIgnoreCase))
                {
                    if (!status.Equals("Saiu para entrega", StringComparison.OrdinalIgnoreCase))
                    {
                        // Botão "Pedido saiu para entrega"
                        Button btnSaiuParaEntrega = new Button
                        {
                            Text = "Pedido saiu para entrega",
                            Location = new Point(650, 20),
                            Size = new Size(150, 30),
                            BackColor = Color.Orange
                        };

                        btnSaiuParaEntrega.Click += (s, args) =>
                        {
                            bd.MudarStatusDoPedidoSaiuPraEntrega(pedido.getId());
                            MessageBox.Show("Pedido marcado como saiu para entrega.");
                            int clientId = pedido.getIdCliente();
                            long? chatId = bd.BuscarChatIdPorUserId(clientId);
                            TelegramController.EnviarStatusPedidoAsync(chatId.Value, "saiu para entrega");
                            CarregarPedidos();
                        };

                        Button btnVerDetalhes = new Button
                        {
                            Text = "Ver Detalhes",
                            Location = new Point(650, 60),
                            Size = new Size(120, 30),
                            BackColor = Color.LightBlue
                        };

                        btnVerDetalhes.Click += (s, args) =>
                        {
                            TelaDetalhesPedido telaDetalhesPedido = new TelaDetalhesPedido(pedido.getId());
                            telaDetalhesPedido.Show();
                            this.Close();
                        };

                        itemPanel.Controls.Add(btnSaiuParaEntrega);
                        itemPanel.Controls.Add(btnVerDetalhes);
                    }
                    else
                    {
                        // Botão "Pedido concluído"
                        Button btnPedidoConcluido = new Button
                        {
                            Text = "Pedido Entregue",
                            Location = new Point(650, 20),
                            Size = new Size(120, 30),
                            BackColor = Color.LightGreen
                        };

                        btnPedidoConcluido.Click += (s, args) =>
                        {
                            bd.MudarStatusDoPedidoEntregue(pedido.getId());
                            MessageBox.Show("Pedido marcado como entregue.");
                            int clientId = pedido.getIdCliente();
                            long? chatId = bd.BuscarChatIdPorUserId(clientId);
                            TelegramController.EnviarStatusPedidoAsync(chatId.Value, "entregue");
                            CarregarPedidos();
                        };

                        Button btnVerDetalhes = new Button
                        {
                            Text = "Ver Detalhes",
                            Location = new Point(650, 60),
                            Size = new Size(120, 30),
                            BackColor = Color.LightBlue
                        };

                        btnVerDetalhes.Click += (s, args) =>
                        {
                            TelaDetalhesPedido telaDetalhesPedido = new TelaDetalhesPedido(pedido.getId());
                            telaDetalhesPedido.Show();
                            this.Close();
                        };

                        itemPanel.Controls.Add(btnPedidoConcluido);
                        itemPanel.Controls.Add(btnVerDetalhes);
                    }
                }
                else
                {
                    // Label "Pedido concluído"
                    Label concluidoLabel = new Label
                    {
                        Text = "Pedido Concluído",
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        ForeColor = Color.ForestGreen,
                        Location = new Point(650, 30),
                        AutoSize = true
                    };

                    Button btnVerDetalhes = new Button
                    {
                        Text = "Ver Detalhes",
                        Location = new Point(650, 60),
                        Size = new Size(120, 30),
                        BackColor = Color.LightBlue
                    };

                    btnVerDetalhes.Click += (s, args) =>
                    {
                        TelaDetalhesPedido telaDetalhesPedido = new TelaDetalhesPedido(pedido.getId());
                        telaDetalhesPedido.Show();
                        this.Close();
                    };

                    itemPanel.Controls.Add(concluidoLabel);
                    itemPanel.Controls.Add(btnVerDetalhes);
                }

                itemPanel.Controls.Add(foto);
                itemPanel.Controls.Add(nomeLabel);
                itemPanel.Controls.Add(quantidadeLabel);
                itemPanel.Controls.Add(totalProdutoLabel);

                flowPanelPedidos.Controls.Add(itemPanel);
            }

            lblItens.Text = itens.ToString();
            lblTotal.Text = total.ToString("C");

        }



        private void button3_Click(object sender, EventArgs e)
        {
            TelaPrincipalRestaurante telaPrincipalRestaurante = new TelaPrincipalRestaurante();
            telaPrincipalRestaurante.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = IdController.GetIdEstablishment();
            TelaCardapio telaCardapio = new TelaCardapio(id.Value);
            telaCardapio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipalRestaurante telaPrincipalRestaurante = new TelaPrincipalRestaurante();
            telaPrincipalRestaurante.Show();
            this.Close();
        }
    }
}
