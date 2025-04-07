using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace UaiFood.Controller
{
    class PasswordController
    {
        private Byte[] salt = new byte[16];
        public void VerificarSenha(String senha)
        {
            // ver sobre regex
        }
        private void gerarHash(string senha)
        {
            gerarSalt();
            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000, HashAlgorithmName.SHA256);
            Byte[] hash = pbkdf2.GetBytes(32);
            // salvar no banco salt e hash 
            System.Diagnostics.Debug.WriteLine(Convert.ToHexString(hash));
        }
        private void gerarHashSalvo(String senha)
        {
            // busca para pegar salt armazenado no banco 
            // busca para pegar hash armazenado no banco e comparar depois
        }
        public void gerarSalt()
        {
            RandomNumberGenerator.Fill(salt);
        }
    }
}
