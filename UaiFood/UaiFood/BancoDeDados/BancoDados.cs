using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.BancoDeDados
{
    class BancoDados
    {
        //4 variáveis declaradas passando as informações do banco de dados
        private const string servidor = "uaifood";
        private const string bancoDados = "dbUsuarios";
        private const string usuario = "root";
        private const string senha = "1234567";

        //declarando variável conexaoBanco para fazer a conexão com o banco de dados
        static public string conexaoBanco = $"server = {servidor}; user id = {usuario}; database= {bancoDados}; password = {senha}";
    }
}
