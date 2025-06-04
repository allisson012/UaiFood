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
        private byte[] imag;
        public TelaCriarPerfilCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageController imageController = new ImageController();
            imag = imageController.SelectImage();
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
            DateOnly data;
            string formato = "dd/MM/yyyy";
            try
            {
                data = DateOnly.ParseExact(dataNasc, formato, System.Globalization.CultureInfo.InvariantCulture);
                System.Diagnostics.Debug.WriteLine($"Data convertida: {data}");
            }
            catch (FormatException)
            {
                System.Diagnostics.Debug.WriteLine("Formato de data inválido.");
                return;
            }
            DocumentController documentController = new DocumentController();
            try
            {
                if (!documentController.validateCpf(cpf))
                {
                    MessageBox.Show("Insira um CPF válido!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insira um CPF válido!", "CPF inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(cidade) && !String.IsNullOrEmpty(rua) && !String.IsNullOrEmpty(numero) && !String.IsNullOrEmpty(cep) && !String.IsNullOrEmpty(telefone) && !String.IsNullOrEmpty(cpf) && !String.IsNullOrEmpty(estado) && data != null && imag != null)
            {
                var userController = new UserController();
                userController.createPerfilUser(IdController.GetIdUser(), nome, cpf, rua, estado, cidade, cep, telefone, numero, imag, data);
            }

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private async void txtCep_Leave(object sender, EventArgs e)
        {
            addressController controller = new addressController();
            var endereco = await controller.viaCepBuscaAsync(txtCep.Text);

            if (endereco != null)
            {
                txtRua.Text = endereco.Rua;
                txtCidade.Text = endereco.Cidade;
                txtEstado.Text = endereco.Estado;
            }
        }
    }
}
