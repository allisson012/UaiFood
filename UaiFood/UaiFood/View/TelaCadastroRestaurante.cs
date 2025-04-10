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
    public partial class TelaCadastroRestaurante : Form
    {
        public TelaCadastroRestaurante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void TelaCadastroRestaurante_Load(object sender, EventArgs e)
        {

        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cnpj = txtCNPJ.Text;

            if(DocumentController.ValidarCNPJ(cnpj))
            {

            }
            else
            {
                MessageBox.Show("CNPJ Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static implicit operator TelaCadastroRestaurante(TelaCadastro v)
        {
            throw new NotImplementedException();
        }
    }
}
