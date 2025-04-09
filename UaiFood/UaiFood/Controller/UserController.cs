using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.View;

namespace UaiFood.Controller
{
    class UserController
    {
        public void createUser(String email, String senha)
        {
            EmailController emailController = new EmailController();
            Boolean validoEmail = emailController.ValidarEmail(email);
            PasswordController passwordController = new PasswordController();
            Boolean senhaValida = passwordController.VerificarSenha(senha);
            if(senhaValida && validoEmail)
            {
                System.Diagnostics.Debug.WriteLine("usuario criado");
                TelaPrincipalCliente p = new TelaPrincipalCliente();
                p.Show();
            }
            else {System.Diagnostics.Debug.WriteLine("usuario não foi criado");}
        }
    }
}
