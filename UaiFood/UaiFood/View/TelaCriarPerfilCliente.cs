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
    public partial class TelaCriarPerfilCliente : Form
    {
        public TelaCriarPerfilCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController();
            byte[] imag = imageController.SelectImage();
            Image i = imageController.ExibirImage(imag);
            if (i != null)
            {
                picturePerfil.Image = i;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cidade = txtCidade.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string cep = txtCep.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCpf.Text;
            string estado = txtEstado.Text;
            string dataNasc = txtDataNascimento.Text;

            DocumentController documentController = new DocumentController();
            if (!documentController.validateCpf(cpf))
            {
                MessageBox.Show("Insira um CPF válido!", "CPF inválido!", (MessageBoxButtons)MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
