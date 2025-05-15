using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Model;
using UaiFood.View;

namespace UaiFood.Controller
{
    class EstablishmentController
    {
        public void createEstablishment(String cnpj, String senha)
        {
            bool cnpjValido = DocumentController.ValidarCNPJ(cnpj);
            var passwordController = new PasswordController();
            var establishment = new Establishment();
            establishment = passwordController.VerificarSenha(senha, establishment);
            if (cnpjValido && establishment.GetHash != null)
            {
                establishment.SetCnpj(cnpj);
                var bancoDados = new BancoDados();
                bancoDados.CreateEstablishmentBank(establishment);
                var telaCriarPerfilRestaurante = new TelaCriarPerfilRestaurante();
                telaCriarPerfilRestaurante.Show();
            }
        }

        public bool createPerfilEstablishment(string nameRestaurante, string email, string street, string state, string city, string cep, string telephone, string numberAddress)
        {
            return false;
        }

        public bool loginEstablishment(string cnpj,string senha)
        {
            var bancoDados = new BancoDados();
            Establishment establishment = bancoDados.getSenhaEstablishmentBank(cnpj);
            if(establishment != null)
            {
                var passwordController = new PasswordController();
                bool senhaValida = passwordController.compareSenhaForEstablishment(senha, establishment);
                if (senhaValida)
                {
                    MessageBox.Show("Usuario logado com sucesso");
                    IdController.SetIdUser(establishment.GetId());
                    return true;
                }
                else
                {
                    MessageBox.Show("erro ao logar usuario email ou senha incorretos");
                }
            }
            else
            {
                MessageBox.Show("estabelecimento não encontrado");
            }
                return false;
        }

    }
}
