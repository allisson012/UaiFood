using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Model;

namespace UaiFood.Controller
{
    class UserController
    {
        public Boolean createUser(String email, String senha)
        {
            User u = new User();
            EmailController emailController = new EmailController();
            Boolean validoEmail = emailController.ValidarEmail(email);
            if(validoEmail)
            {
                u.setEmail(email);
            }
            PasswordController passwordController = new PasswordController();
            u = passwordController.VerificarSenha(senha,u);
            if (u.getEmail != null && u.getHash() != null)
            {
                System.Diagnostics.Debug.WriteLine("email é valido");
                var bancoDados = new BancoDados();
                bancoDados.CreateUserBank(u);
                return true;
            }
            else { return false; }
        }
    }
}
