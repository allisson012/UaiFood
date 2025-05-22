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
using UaiFood.Model;
using Image = System.Drawing.Image;

namespace UaiFood.View
{
    public partial class TelaEditarPerfilCliente : Form
    {
        private byte[] imag;
        public TelaEditarPerfilCliente()
        {
            InitializeComponent();
            BancoDados bancoDados = new BancoDados();
            User user = bancoDados.findUserById(1);
            txtCep.Text = user.getAddress().getCep();
            txtCidade.Text = user.getAddress().getCity();
            txtEstado.Text = user.getAddress().getState();
            txtRua.Text = user.getAddress().getStreet();
            txtNumero.Text = user.getAddress().getNumberAddress();
            txtNome.Text = user.getNome();
            txtTelefone.Text = user.getTelefone();
            txtCpf.Text = user.getCpf();
            txtDataNascimento.Text = user.getData().ToString();
            ImageController imageController = new ImageController();
            picturePerfil.Image = imageController.ExibirImage(user.getPhoto());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaPerfilCliente telaPerfilCliente = new TelaPerfilCliente();
            telaPerfilCliente.Show();
            this.Close();
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
            if (!documentController.validateCpf(cpf))
            {
                MessageBox.Show("Insira um CPF válido!", "CPF inválido!", (MessageBoxButtons)MessageBoxIcon.Warning);
                return;
            }
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(cidade) && !String.IsNullOrEmpty(rua) && !String.IsNullOrEmpty(numero) && !String.IsNullOrEmpty(cep) && !String.IsNullOrEmpty(telefone) && !String.IsNullOrEmpty(cpf) && !String.IsNullOrEmpty(estado) && data != null && imag != null)
            {
                var userController = new UserController();
                IdController.SetIdUser(1);
                userController.createPerfilUser(IdController.GetIdUser(), nome, cpf, rua, estado, cidade, cep, telefone, numero, imag, data);
            }
        }
    }
}
