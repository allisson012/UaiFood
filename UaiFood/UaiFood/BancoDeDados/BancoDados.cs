using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using UaiFood.Model;
using System.Data;
using UaiFood.BancoDeDados;
using UaiFood.Controller;

namespace UaiFood.BancoDeDados
{
    namespace UaiFood.BancoDeDados
    {
        class BancoDados
        {
            private const string servidor = "localhost";
            private const string bancoDados = "UaiFood";
            private const string usuario = "root";
            private const string senha = "pedro";
            private static MySqlConnection connection;
            static public string conexaoServidor = $"server={servidor};user id={usuario};password={senha}";

            // ordem da classe banco de dados
            // estrutura do banco -> user -> establishment -> cardapio -> product -> outros
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
            //user
            public void createTableUser()
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
                        System.Diagnostics.Debug.WriteLine("tabela users criada com sucesso");
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
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
                                String cpf = reader.GetString("cpf");
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

            public Boolean RegisterNewPassword(User user)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string email = user.getEmail();
                    byte[] newPassword = user.getHash();
                    byte[] newSalt = user.getSalt();

                    string sql = "SELECT * FROM users WHERE email = @email";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reader.Close(); // Fecha o reader antes de executar outro comando

                                string updateSql = "UPDATE users SET hash = @hash, salt = @salt WHERE email = @email";
                                using (var updateCmd = new MySqlCommand(updateSql, connection))
                                {
                                    updateCmd.Parameters.AddWithValue("@hash", newPassword);
                                    updateCmd.Parameters.AddWithValue("@salt", newSalt); // ESSENCIAL
                                    updateCmd.Parameters.AddWithValue("@email", email);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        System.Diagnostics.Debug.WriteLine("Senha atualizada com sucesso.");
                                        return true;
                                    }
                                    else
                                    {
                                        System.Diagnostics.Debug.WriteLine("Erro ao atualizar a senha.");
                                        return false;
                                    }
                                }
                            }
                            else
                            {
                                System.Diagnostics.Debug.WriteLine("Usuário não encontrado.");
                                return false;
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return false;
                }
            }
            //establishment
            public void createTableEstablishment()
            {
                string sql = @"
CREATE TABLE IF NOT EXISTS establishment (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    hash BLOB NOT NULL,
    salt BLOB NOT NULL,
    image BLOB,
    telefone VARCHAR(11) UNIQUE,
    cnpj VARCHAR(14) NOT NULL UNIQUE,
    cep VARCHAR(8),
    estado VARCHAR(100),
    cidade VARCHAR(100),
    rua VARCHAR(100),
    numero VARCHAR(100)
);";

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("tabela establishment criada com sucesso");
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

            public bool CreateEstablishmentBank(Establishment establishment)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "INSERT INTO establishment (hash,salt,cnpj) VALUES(@hash,@salt,@cnpj)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        byte[] hash = establishment.GetHash();
                        byte[] salt = establishment.GetSalt();
                        string cnpj = establishment.GetCnpj();
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@salt", salt);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            long idRestaurante = cmd.LastInsertedId;
                            int idRestauranteForIdController = (int)idRestaurante;
                            IdController.SetIdEstablishment(idRestauranteForIdController);
                            System.Diagnostics.Debug.WriteLine("ID setado no IdController = " + IdController.GetIdEstablishment());
                            createCardapio(idRestaurante);
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Erro MySQL: " + ex.Message);
                    return false;
                }
                return false;
            }

            public Establishment getSenhaEstablishmentBank(String cnpj)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "SELECT * FROM establishment WHERE cnpj = @cnpj";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var establishment = new Establishment();
                                establishment.SetId(reader.GetInt32("id"));
                                establishment.SetCnpj(reader.GetString("cnpj"));
                                establishment.SetHash(GetBytesFromReader(reader, "hash"));
                                establishment.SetSalt(GetBytesFromReader(reader, "salt"));
                                return establishment;
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

            public bool completePerfilRestaurante(Establishment establishment)
            {
                System.Diagnostics.Debug.WriteLine("ID recuperado no IdController = " + IdController.GetIdEstablishment());
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "UPDATE establishment SET nome = @nome, email = @email, image = @image, telefone = @telefone, cep = @cep, estado = @estado, cidade = @cidade, rua = @rua, numero = @numero WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        byte[] image = establishment.GetImage();
                        string nome = establishment.GetNome();
                        string email = establishment.GetEmail();
                        string telefone = establishment.GetTelefone();
                        string cep = establishment.GetAddressEstablishment().getCep();
                        string estado = establishment.GetAddressEstablishment().getState();
                        string cidade = establishment.GetAddressEstablishment().getCity();
                        string rua = establishment.GetAddressEstablishment().getStreet();
                        string numero = establishment.GetAddressEstablishment().getNumberAddress();
                        int id = IdController.GetIdEstablishment();
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@rua", rua);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    return false;
                }
                return false;
            }

            public bool EstabelecimentoCadastroCompleto(int idEstablishment)
            {
                Createconnection();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                string query = @"
            SELECT nome, email, image, telefone, cep, estado, cidade, rua, numero
            FROM establishment
            WHERE id = @id";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idEstablishment);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string[] campos = new string[]
                            {
                        reader["nome"]?.ToString(),
                        reader["email"]?.ToString(),
                        reader["image"]?.ToString(),
                        reader["telefone"]?.ToString(),
                        reader["cep"]?.ToString(),
                        reader["estado"]?.ToString(),
                        reader["cidade"]?.ToString(),
                        reader["rua"]?.ToString(),
                        reader["numero"]?.ToString(),
                            };

                            return campos.All(c => !string.IsNullOrWhiteSpace(c));
                        }
                    }
                }


                return false; // Se não encontrar ou houver erro, assume que está incompleto
            }

            public Establishment findEstablishmentById(int id)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    String sql = "SELECT * FROM establishment WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var addressEstablishment = new AddressEstablishment();
                                var establishment = new Establishment();
                                establishment.SetId(reader.GetInt32("id"));
                                establishment.SetNome(reader.GetString("nome"));
                                establishment.SetEmail(reader.GetString("email"));
                                establishment.SetHash(GetBytesFromReader(reader, "hash"));
                                establishment.SetSalt(GetBytesFromReader(reader, "salt"));
                                establishment.SetImage(GetBytesFromReader(reader, "image"));
                                establishment.SetTelefone(reader.GetString("telefone"));
                                establishment.SetCnpj(reader.GetString("cnpj"));
                                addressEstablishment.setCep(reader.GetString("cep"));
                                addressEstablishment.setState(reader.GetString("estado"));
                                addressEstablishment.setCity(reader.GetString("cidade"));
                                addressEstablishment.setStreet(reader.GetString("rua"));
                                addressEstablishment.setNumberAddress(reader.GetString("numero"));
                                establishment.SetAddressEstablishment(addressEstablishment);
                                return establishment;
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

            //cardapio

            public void createCardapioTable()
            {
                string sql = @"
CREATE TABLE IF NOT EXISTS cardapio (
    id INT PRIMARY KEY AUTO_INCREMENT,
    idRestaurante INT UNIQUE NOT NULL,
    FOREIGN KEY (idRestaurante) REFERENCES establishment(id)
);";

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("Tabela cardapio criada com sucesso.");
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao tentar criar tabela: " + e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            private void createCardapio(long id)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "INSERT INTO cardapio (idRestaurante) VALUES(@idRestaurante)";
                    int idrestaurante = (int)id;
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@idRestaurante", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    
                }
            }

            //produtos

            public void createProductTable()
            {
                string sql = @"
CREATE TABLE IF NOT EXISTS produtos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    descricao VARCHAR(500),
    preco DECIMAL(10, 2) NOT NULL,
    categoria VARCHAR(100),
    imagem BLOB,
    idCardapio INT NOT NULL,
    FOREIGN KEY (idCardapio) REFERENCES cardapio(id)
);";

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine("Tabela produto criada com sucesso.");
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao tentar criar tabela: " + e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            public bool CadastrarProduto(Produto produto)
            {
                try
                {
                    Createconnection();

                    // Verifique se a conexão já está aberta antes de abrir
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open(); 
                    }

                    connection.ChangeDatabase(bancoDados);

                    string sql = "INSERT INTO produtos (nome, descricao, preco, categoria, imagem ,idCardapio) " +
                                 "VALUES (@nome, @descricao, @preco, @categoria, @imagem , @idCardapio)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto.Nome);
                        cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                        cmd.Parameters.AddWithValue("@preco", produto.Preco);
                        cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                        cmd.Parameters.AddWithValue("@imagem", produto.Imagem);
                        // passar o idController do establishment
                        cmd.Parameters.AddWithValue("@idCardapio", IdController.GetIdEstablishment());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Erro: {ex.Message}\nStack Trace: {ex.StackTrace}");
                    MessageBox.Show($"Erro: {ex.Message}\nStack Trace: {ex.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        public Produto ConsultarProdutoPorId(int id)
        {
            try
            {
                Createconnection();
                connection.ChangeDatabase(bancoDados);

                string sql = "SELECT * FROM produtos WHERE id = @id";

                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Produto
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Descricao = reader.GetString("descricao"),
                                Preco = reader.GetDecimal("preco"),
                                Categoria = reader.GetString("categoria"),
                                Imagem = reader["imagem"] as byte[]
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro ao consultar produto: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return null;
        }

        public List<Produto> ListarProdutos()
        {
            List<Produto> produtos = new List<Produto>();

            try
            {
                Createconnection();
                connection.ChangeDatabase(bancoDados);

                string sql = "SELECT * FROM produtos";

                using (var cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produtos.Add(new Produto
                            {
                                Id = reader.GetInt32("id"),
                                Nome = reader.GetString("nome"),
                                Descricao = reader.GetString("descricao"),
                                Preco = reader.GetDecimal("preco"),
                                Categoria = reader.GetString("categoria"),
                                Imagem = reader["imagem"] as byte[]
                                
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erro ao listar produtos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return produtos;
            }

            public bool DeletarProduto(int id)
            {
                try
                {
                    Createconnection();
                    connection.ChangeDatabase(bancoDados);

                    string sql = "DELETE FROM produtos WHERE id = @id";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao deletar produto: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            //outros
            private static byte[] GetBytesFromReader(MySqlDataReader reader, string columnName)
            {
                long size = reader.GetBytes(reader.GetOrdinal(columnName), 0, null, 0, 0); // pega o tamanho
                byte[] buffer = new byte[size];
                reader.GetBytes(reader.GetOrdinal(columnName), 0, buffer, 0, (int)size); // copia os bytes
                return buffer;
            }


        }
    }
    }





