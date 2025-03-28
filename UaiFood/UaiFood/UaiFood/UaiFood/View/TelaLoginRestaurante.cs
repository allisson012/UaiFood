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
    public partial class TelaLoginRestaurante : Form
    {
        public TelaLoginRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroRestaurante telaCadastroRestaurante = new TelaCadastroRestaurante();
            telaCadastroRestaurante.Show();
        }
    }
}
