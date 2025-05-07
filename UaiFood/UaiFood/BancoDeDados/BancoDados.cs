using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UaiFood.Model;
namespace UaiFood.BancoDeDados
{
    using System.Data;
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
                }
                finally
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
    cpf VARCHAR(14) UNIQUE,
    telefone VARCHAR(11),
    data DATE
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
            public void createTableEstablishment()
            {
                string sql = @"
CREATE TABLE IF NOT EXISTS establishment (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    hash BLOB NOT NULL,
    salt BLOB NOT NULL,
    cpf VARCHAR(14) UNIQUE,
    telefone VARCHAR(11),
    cnpj VARCHAR(14),
    endereco VARCHAR(100),
    estado VARCHAR(100),
    cidade VARCHAR(100),
    bairro VARCHAR(100),
    rua VARCHAR(100),
    numero VARCHAR(100),
    complemento VARCHAR(100)
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
            public Boolean RegisterUserBank(User u)
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
                        String nome = email.Substring(0, email.IndexOf('@'));
                        byte[] hash = u.getHash();
                        byte[] salt = u.getSalt();
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@salt", salt);

                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("inseriu");
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro: " + ex.Message);
                    return false;
                }
            }
            public User getSenhaUserBank(String email)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "SELECT * FROM users WHERE email = @email";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var user = new User();
                                user.setId(reader.GetInt32("id"));
                                user.setNome(reader.GetString("nome"));
                                user.setEmail(reader.GetString("email"));
                                user.setHash(GetBytesFromReader(reader, "hash"));
                                user.setSalt(GetBytesFromReader(reader, "salt"));
                                return user;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro: " + ex.Message);
                    return null;
                }
            }
            private static byte[] GetBytesFromReader(MySqlDataReader reader, string columnName)
            {
                long size = reader.GetBytes(reader.GetOrdinal(columnName), 0, null, 0, 0); // pega o tamanho
                byte[] buffer = new byte[size];
                reader.GetBytes(reader.GetOrdinal(columnName), 0, buffer, 0, (int)size); // copia os bytes
                return buffer;
            }
            // editUser
            // Consulat user
            public Boolean deleteUserBank(int id)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "DELETE FROM users WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            System.Diagnostics.Debug.WriteLine("Usuário deletado");
                            return true;
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("Nenhum usuário encontrado com esse ID");
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine("erro " + ex.Message);
                    return false;
                }
            }

            public User findUserById(int id)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    String sql = "SELECT * FROM users WHERE id = @id";
                    using(var cmd = new MySqlCommand(sql,connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using(var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var user = new User();
                                user.setId(reader.GetInt32("id"));
                                user.setNome(reader.GetString("nome"));
                                user.setEmail(reader.GetString("email"));
                                user.setHash(GetBytesFromReader(reader, "hash"));
                                user.setSalt(GetBytesFromReader(reader, "salt"));
                                String cpf = reader.GetString("cep");
                                user.setCpf(long.Parse(cpf));
                                return user;
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
                return null;
            }
        }
    }
}



