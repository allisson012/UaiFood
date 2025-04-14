using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    internal class CodigoController
    {
        private static Random random = new Random();
        public static string GerarCodigoNumerico(int tamanho = 6)
        {
            string numeros = "0123456789";
            char[] codigo = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                codigo[i] = numeros[random.Next(numeros.Length)];
            }

            return new string(codigo);
        }
    }
}
