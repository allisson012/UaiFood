using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiFood.Controller;

namespace UaiFood.View
{
    public partial class TelaPedidosRestaurante : Form
    {
        public TelaPedidosRestaurante()
        {
            InitializeComponent();
        }

        private void TelaPedidosRestaurante_Load(object sender, EventArgs e)
        {

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
