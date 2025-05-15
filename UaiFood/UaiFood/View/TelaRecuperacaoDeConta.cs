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
    public partial class TelaRecuperacaoDeConta : Form
    {
        private string codigo;
        private string destinatario;
        public TelaRecuperacaoDeConta(string codigo, string destinatario)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.destinatario = destinatario;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            UserController userController = new UserController();
            System.Diagnostics.Debug.WriteLine("Botão funcionando");
            if (codigo == txtCodigo.Text && destinatario == txtEmail.Text)
            {
                if (txtSenha.Text.Equals(txtRepete.Text))
                {
                   if( userController.UpdatePassword(txtEmail.Text, txtSenha.Text))
                    {
                        MessageBox.Show("Senha atualizada com sucesso!");
                        TelaLogin telaLogin = new TelaLogin();
                        telaLogin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar senha!");
                    }
                }
            }
        }
    }
}
