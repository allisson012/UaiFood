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
    public partial class TelaPesquisa : Form
    {
        int? clienteLogado = IdController.GetIdUser();

        public TelaPesquisa()
        {
            InitializeComponent();
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
    }
}
