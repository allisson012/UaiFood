using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    class EmailController
    {
        private static  string[] ALLOWED_PROVIDERS = { "@gmail.com", "@outlook.com", "@hotmail.com", "@yahoo.com", "@yahoo.com.br",
			"@icloud.com" , "@fatec.sp.gov.br" };
        public Boolean ValidarEmail(String email)
        {
            Boolean atArroba = email.Contains('@');
            int index = email.IndexOf('@');
            char[] emailCaracteres = email.ToCharArray();
            int quantidadeArroba = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (emailCaracteres[i] == '@')
                {
                    quantidadeArroba++;
                }
            }
            Boolean ArrobaUm = quantidadeArroba == 1 ? true : false;
            String provedor = "";
            Boolean provedorVerdadeiro = false;
            if (index >= 0)
            {
                provedor = email.Substring(index);
            }
            Boolean terminaComProvedor = false;
            for (int i = 0; i < ALLOWED_PROVIDERS.Length; i++)
            {
                if (provedor.Equals(ALLOWED_PROVIDERS[i]) && email.EndsWith(ALLOWED_PROVIDERS[i]))
                {
                    provedorVerdadeiro = true;
                    terminaComProvedor = true;
                }
            }
            if(provedorVerdadeiro && atArroba && ArrobaUm && terminaComProvedor)
            {
                System.Diagnostics.Debug.WriteLine("email verdadeiro");
                return true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("email falso");
                return false;
            }
         
        }
    }
}
