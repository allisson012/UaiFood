using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UaiFood.View
{
    public partial class TelaPrincipalRestaurante : Form
    {
        public TelaPrincipalRestaurante()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelaAdicionarProduto telaAdicionarProduto = new TelaAdicionarProduto();
            telaAdicionarProduto.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TelaEditarProduto telaEditarProduto = new TelaEditarProduto();
            telaEditarProduto.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaEditarPerfilRestaurante telaEditarPerfilRestaurante = new TelaEditarPerfilRestaurante();
            telaEditarPerfilRestaurante.Show();
        }
    }
}
