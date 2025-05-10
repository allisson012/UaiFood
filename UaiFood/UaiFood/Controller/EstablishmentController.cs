using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Model;

namespace UaiFood.Controller
{
    class EstablishmentController
    {
        public void createEstablishment(String cnpj,String senha)
        {
            bool cnpjValido = DocumentController.ValidarCNPJ(cnpj);
            var passwordController = new PasswordController();
            var establishment = new Establishment();
            establishment = passwordController.VerificarSenha(senha,establishment);
            if(cnpjValido && establishment.GetHash != null)
            {
                establishment.SetCnpj(cnpj);
                var bancoDados = new BancoDados();
                bancoDados.CreateEstablishmentBank(establishment);
            }
        }
    }
}
