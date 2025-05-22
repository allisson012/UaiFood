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
            BancoDados bd = new BancoDados();

            if (cbFiltro.SelectedIndex == 0)
            {
                var restaurantes = bd.BuscarRestaurantes(txtPesquisa.Text);

                flpRestaurantes.Controls.Clear();
                ImageController imgController = new ImageController();

                foreach (var restaurante in restaurantes)
                {
                    Panel card = new Panel();
                    card.Width = 120;
                    card.Height = 150;
                    card.Margin = new Padding(10);
                    card.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox pb = new PictureBox();
                    pb.Width = 100;
                    pb.Height = 100;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = imgController.ExibirImage(restaurante.GetImage());

                    pb.Location = new Point(10, 10);
                    card.Controls.Add(pb);

                    Label lbl = new Label();
                    lbl.Text = restaurante.GetNome();
                    lbl.AutoSize = false;
                    lbl.Width = 100;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Location = new Point(10, 115);

                    card.Controls.Add(lbl);

                    flpRestaurantes.Controls.Add(card);
                }
            }

            else if (cbFiltro.SelectedIndex == 1)
            {
                var produtos = bd.BuscarTodosProdutos(txtPesquisa.Text);

                flpRestaurantes.Controls.Clear();
                ImageController imgController = new ImageController();

                foreach (var produto in produtos)
                {
                    Panel card = new Panel();
                    card.Width = 120;
                    card.Height = 150;
                    card.Margin = new Padding(10);
                    card.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox pb = new PictureBox();
                    pb.Width = 100;
                    pb.Height = 100;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = imgController.ExibirImage(produto.Imagem);

                    pb.Location = new Point(10, 10);
                    card.Controls.Add(pb);

                    Label lbl = new Label();
                    lbl.Text = produto.Nome;
                    lbl.AutoSize = false;
                    lbl.Width = 100;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Location = new Point(10, 115);

                    card.Controls.Add(lbl);

                    flpRestaurantes.Controls.Add(card);
                }
            }
            else if (cbFiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um flitro de pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void TelaPesquisa_Load(object sender, EventArgs e)
        {

            BancoDados bd = new BancoDados();

            if (cbFiltro.SelectedIndex == 0)
            {
                var restaurantes = bd.ExibirRestaurantes();

                flpRestaurantes.Controls.Clear();
                ImageController imgController = new ImageController();

                foreach (var restaurante in restaurantes)
                {
                    Panel card = new Panel();
                    card.Width = 120;
                    card.Height = 150;
                    card.Margin = new Padding(10);
                    card.BorderStyle = BorderStyle.FixedSingle;

                    PictureBox pb = new PictureBox();
                    pb.Width = 100;
                    pb.Height = 100;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = imgController.ExibirImage(restaurante.GetImage());

                    pb.Location = new Point(10, 10);
                    card.Controls.Add(pb);

                    Label lbl = new Label();
                    lbl.Text = restaurante.GetNome();
                    lbl.AutoSize = false;
                    lbl.Width = 100;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Location = new Point(10, 115);

                    card.Controls.Add(lbl);

                    flpRestaurantes.Controls.Add(card);
                }
            }
        }
    }
}
