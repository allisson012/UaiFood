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
    public partial class TelaExibirRestaurante : Form
    {
        public TelaExibirRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPesquisa telaPesquisa = new TelaPesquisa();
            telaPesquisa.Show();
            this.Close();
        }
    }
}
