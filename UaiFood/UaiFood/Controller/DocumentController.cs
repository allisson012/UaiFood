using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UaiFood.Controller
{
    internal class DocumentController
    {
        public static bool ValidarCNPJ(string cnpj)
        {
            cnpj = cnpj.Trim();
            cnpj = Regex.Replace(cnpj, "[^0-9]", "");

            System.Diagnostics.Debug.WriteLine($"CNPJ recebido: [{cnpj}]");
            System.Diagnostics.Debug.WriteLine($"Tamanho: {cnpj.Length}");
            foreach (char c in cnpj)
            {
                System.Diagnostics.Debug.WriteLine($"'{c}' -> {(int)c}");
            }

            if (cnpj.Length != 14)
                return false;

            if (new string(cnpj[0], cnpj.Length) == cnpj)
                return false;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCnpj += digito;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }


        public bool validateCpf(string cpf)
        {
            cpf = Regex.Replace(cpf, "[^0-9]", "");
            bool valid = false;
            if (cpf.Length != 11 || System.Text.RegularExpressions.Regex.IsMatch(cpf, @"(\d)\1{10}")
)
            {
                System.Diagnostics.Debug.WriteLine("CPF inválido");
                return false;
            }

            int[] cpfArray = ConvertCpfToArray(cpf);

            if (IsCpf(1, cpfArray) == true)
            {
                System.Diagnostics.Debug.WriteLine("é um cpf valido");
                valid = true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Cpf nao e valido");
            }
            return valid;
        }

        private int[] ConvertCpfToArray(string cpf)
        {
            int[] cpfArray = new int[11];
            for (int i = 0; i <= 10; i++)
            {
                cpfArray[i] = int.Parse(cpf[i].ToString());
            }
            return cpfArray;
        }

        private bool IsCpf(int posicaoCodigo, int[] cpfArray)
        {
            int j = 0;

            if (posicaoCodigo == 1)
            {
                j = 10;
            }
            else
            {
                j = 11;
            }
            int indexParameter = 7 + posicaoCodigo;

            int resultado = 0;
            for (int i = 0; i <= indexParameter; i++)
            {
                resultado += j * cpfArray[i];
                j--;
            }
            int restoDiv = resultado % 11;
            if (restoDiv < 2)
            {
                if (cpfArray[indexParameter + 1] == 0)
                {
                    if (posicaoCodigo == 1)
                    {
                        return IsCpf(2, cpfArray);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                int dif = 11 - restoDiv;
                if (cpfArray[indexParameter + 1] == dif)
                {
                    if (posicaoCodigo == 1)
                    {
                        return IsCpf(2, cpfArray);
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
