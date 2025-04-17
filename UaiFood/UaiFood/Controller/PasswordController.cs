﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UaiFood.Model;
namespace UaiFood.Controller
{
    class PasswordController
    {
        private Byte[] salt = new byte[16];
        private User userRecebe;
        public User VerificarSenha(String senha,User user)
        {
            Boolean caractereEspecial = Regex.IsMatch(senha, "[@#!$%&]");
            Boolean caractereNumerico = Regex.IsMatch(senha, "[0-9]");
            Boolean caractereMaiusculo = Regex.IsMatch(senha, "[A-Z]");
            Boolean tamanho = senha.Length >= 8 ? true : false;
            userRecebe = user;
            if (caractereEspecial && caractereNumerico && caractereMaiusculo && tamanho)
            {
                System.Diagnostics.Debug.WriteLine("senha valida");
                gerarHash(senha,userRecebe);
                return userRecebe;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("senha fornecida não atende aos padroes pedidos");
                // Mensagem de erro
                return null;
            }
        }
        private void gerarHash(string senha , User user)
        {
            gerarSalt();
            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 10000, HashAlgorithmName.SHA256);
            Byte[] hash = pbkdf2.GetBytes(32);
            userRecebe.setSalt(salt);
            userRecebe.setHash(hash);
            System.Diagnostics.Debug.WriteLine(Convert.ToHexString(hash));
        }
        public void gerarSalt()
        {
            RandomNumberGenerator.Fill(salt);
        }
        public void compararSenha(String senha)
        {
            // busca para pegar salt armazenado no banco 
            // usar o salt salva para gerar um hash e depois comparar
            // busca para pegar hash armazenado no banco e comparar depois
        }
    }
}
