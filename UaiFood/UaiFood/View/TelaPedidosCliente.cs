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
    public partial class TelaPedidosCliente : Form
    {
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
    }
}
