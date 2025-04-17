using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UaiFood.Model;
namespace UaiFood.BancoDeDados
{
    
    using MySql.Data.MySqlClient;
   

    namespace UaiFood.BancoDeDados
    {
        class BancoDados
        {
            private const string servidor = "localhost";
            private const string bancoDados = "UaiFood";
            private const string usuario = "root";
            private const string senha = "";
            private static MySqlConnection connection;
            static public string conexaoServidor = $"server={servidor};user id={usuario};password={senha}";

            public static void Createconnection()
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(conexaoServidor);
                }
            }

            public void createBank()
            {
                Createconnection();
                try
                {
                    connection.Open();
                    string sql = $"CREATE DATABASE IF NOT EXISTS `{bancoDados}`;";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("banco de dados criado com sucesso");
                    }

                    connection.ChangeDatabase(bancoDados); 
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("Erro estrutura: " + e.Message);
                }finally
                {
                    connection.Close();
                }
            }

            public void createTable()
            {
                string sql = @"
CREATE TABLE IF NOT EXISTS users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    hash BLOB NOT NULL,
    salt BLOB NOT NULL,
    image BLOB,
    cpf VARCHAR(14) UNIQUE
);";

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("tabela criada com sucesso");
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("erro ao tentar criar tabela");
                }
                finally
                {
                    connection.Close();
                }
            }
         public void CreateUserBank(User u)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string sql = "INSERT INTO users (nome, email, hash, salt) VALUES (@nome, @email, @hash, @salt)";


                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        String email = u.getEmail();
                        byte[] hash = u.getHash();
                        byte[] salt = u.getSalt();
                        cmd.Parameters.AddWithValue("@nome", "allisson");
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@salt", salt);

                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("inseriu");
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro: " + ex.Message);
                }
            }

        }
    }
}



