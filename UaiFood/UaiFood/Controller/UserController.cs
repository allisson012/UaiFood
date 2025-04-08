using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    class UserController
    {
        public Boolean createUser(String email, String senha)
        {
            EmailController emailController = new EmailController();
            Boolean validoEmail = emailController.ValidarEmail(email);
            if(senha != null && validoEmail)
            {
                System.Diagnostics.Debug.WriteLine("email é valido");
                return true;
            }
            else { return false; }
        }
    }
}
