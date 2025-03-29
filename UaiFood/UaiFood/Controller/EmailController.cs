using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    class EmailController
    {
        public void ValidarEmail(String email)
        {
            char[] a = email.ToCharArray();
            for(int i = 0; i<a.Length; i++)
            {
                if(a.Contains('@'))
                {
                    
                }

            }
        }
    }
}
