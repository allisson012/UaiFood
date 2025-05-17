using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UaiFood.Model;
using System.Security.Policy;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
namespace UaiFood.Controller
{
    class PasswordController
    {
        private Byte[] salt = new byte[16];
        private Establishment establishmentRecebe;
        private User userRecebe; // variavel para receber o valor de user , para que consiga modificar essa variavel atraves dos metodos
        // metodo para verificar se a senha tem caractere especial letra maiuscula caractere numero e se tem oito ou mais caracteres
        public User VerificarSenha(String senha, User user)
        {
            Boolean caractereEspecial = Regex.IsMatch(senha, "[@#!$%&]");
            Boolean caractereNumerico = Regex.IsMatch(senha, "[0-9]");
            Boolean caractereMaiusculo = Regex.IsMatch(senha, "[A-Z]");
            Boolean tamanho = senha.Length >= 8 ? true : false;
            userRecebe = user;
            if (caractereEspecial && caractereNumerico && caractereMaiusculo && tamanho)
            {
                System.Diagnostics.Debug.WriteLine("senha valida");
                gerarHash(senha);
                return userRecebe;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("senha fornecida não atende aos padroes pedidos");
                // Mensagem de erro
                return userRecebe;
            }
        }
        // faz a criptografia da senha atraves do algoritmo pbkdf2 que recebe como parametro a senha , salt , quantidade de iterações e padrão do algoritmo de criptografia que no caso é sha256 com isso ele gera um hash
        private void gerarHash(string senha)
        {
            gerarSalt();
            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000, HashAlgorithmName.SHA256);
            Byte[] hash = pbkdf2.GetBytes(32);
            userRecebe.setSalt(salt);
            userRecebe.setHash(hash);
            System.Diagnostics.Debug.WriteLine(Convert.ToHexString(hash));
        }
        // metodo para gerar uma palavra aleatoria de 16 bytes
        public void gerarSalt()
        {
            RandomNumberGenerator.Fill(salt);
        }
        public Boolean compareSenha(String senha, User userCompare)
        {
            byte[] hashCompare = gerarHashAtravesDaSalt(senha, userCompare.getSalt());
            string hex = BitConverter.ToString(hashCompare).Replace("-", "").ToLower();
            string hexOriginal = BitConverter.ToString(userCompare.getHash()).Replace("-", "").ToLower();
            System.Diagnostics.Debug.WriteLine("hash salva = "+hexOriginal);
            System.Diagnostics.Debug.WriteLine("hash gerada = "+hex);
            bool areEqual = CryptographicOperations.FixedTimeEquals(
                userCompare.getHash(),
                hashCompare
            );
            return areEqual;
        }
        private byte[] gerarHashAtravesDaSalt(string senha, byte[] saltSalvo)
        {

            var pbkdf2 = new Rfc2898DeriveBytes(senha, saltSalvo, 10000, HashAlgorithmName.SHA256);
            Byte[] hashCompare = pbkdf2.GetBytes(32);
            return hashCompare;
        }
        public Establishment VerificarSenha(String senha, Establishment establishment)
        {
            establishmentRecebe = establishment;
            Boolean caractereEspecial = Regex.IsMatch(senha, "[@#!$%&]");
            Boolean caractereNumerico = Regex.IsMatch(senha, "[0-9]");
            Boolean caractereMaiusculo = Regex.IsMatch(senha, "[A-Z]");
            Boolean tamanho = senha.Length >= 8 ? true : false;
            
            if (caractereEspecial && caractereNumerico && caractereMaiusculo && tamanho)
            {
                System.Diagnostics.Debug.WriteLine("senha valida");
                gerarHashForEstablishment(senha);
                return establishmentRecebe;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("senha fornecida não atende aos padroes pedidos");
                // Mensagem de erro
                return establishment;
            }
        }
        private byte[] gerarHashForEstablishment(string senha)
        {
            gerarSalt();
            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000, HashAlgorithmName.SHA256);
            Byte[] hash = pbkdf2.GetBytes(32);
            establishmentRecebe.SetSalt(salt);
            establishmentRecebe.SetHash(hash);
            System.Diagnostics.Debug.WriteLine("Hash establishment: " + BitConverter.ToString(hash));
            System.Diagnostics.Debug.WriteLine("Salt establishment: " + BitConverter.ToString(salt));
            return hash;
        }
        public Boolean compareSenhaForEstablishment(String senha, Establishment establishmentCompare)
        {
            byte[] hashCompare = gerarHashAtravesDaSalt(senha, establishmentCompare.GetSalt());
            string hex = BitConverter.ToString(hashCompare).Replace("-", "").ToLower();
            string hexOriginal = BitConverter.ToString(establishmentCompare.GetHash()).Replace("-", "").ToLower();
            System.Diagnostics.Debug.WriteLine("hash salva = " + hexOriginal);
            System.Diagnostics.Debug.WriteLine("hash gerada = " + hex);
            bool areEqual = CryptographicOperations.FixedTimeEquals(
                establishmentCompare.GetHash(),
                hashCompare
            );
            return areEqual;
        }

    }
}
