using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
   
    class User
    {
        private String nome;
        int UserId;
        private int idade;
        private byte [] photo;
        private Address address;
        private long cpf;
        public bool User()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(MysqlConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"insert into usuarios (nome, email, photo, adress, cpf) values '{nome}', '{idade}', '{photo}', '{address}', '{cpf}'";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
                return false;
            }
        }
    }
}
