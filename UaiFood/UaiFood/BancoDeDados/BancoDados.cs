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
            // estrutura do banco -> user -> establishment -> cardapio -> product -> pedidos -> outros
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
    nome VARCHAR(100),
    email VARCHAR(100) NOT NULL UNIQUE,
    hash BLOB NOT NULL,
    salt BLOB NOT NULL,
    image LONGBLOB,
    cpf VARCHAR(14) UNIQUE,
    telefone VARCHAR(11),
    cep VARCHAR(8),
    estado VARCHAR(100),
    cidade VARCHAR(100),
    rua VARCHAR(100),
    numero VARCHAR(100),
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

                    string sql = "INSERT INTO users (email, hash, salt) VALUES (@email, @hash, @salt)";


                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        String email = u.getEmail();
                        byte[] hash = u.getHash();
                        byte[] salt = u.getSalt();
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@hash", hash);
                        cmd.Parameters.AddWithValue("@salt", salt);
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            long idUser = cmd.LastInsertedId;
                            int idUserForId = (int)idUser;
                            IdController.SetIdUser(idUserForId);

                            System.Diagnostics.Debug.WriteLine("inseriu");
                            return true;
                        }
                        return false;
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
                                user.setPhoto(GetBytesFromReader(reader, "image"));
                                user.setCpf(reader.GetString("cpf"));
                                user.setTelefone(reader.GetString("telefone"));
                                var address = new AddressUser();
                                address.setCep(reader.GetString("cep"));
                                address.setState(reader.GetString("estado"));
                                address.setCity(reader.GetString("cidade"));
                                address.setStreet(reader.GetString("rua"));
                                address.setNumberAddress(reader.GetString("numero"));
                                user.setAddress(address);
                                DateTime data = reader.GetDateTime("data");
                                DateOnly data2 = DateOnly.FromDateTime(data);
                                user.setData(data2);
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
                                reader.Close();

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

            public bool completePerfilUser(User user)
            {
                System.Diagnostics.Debug.WriteLine("ID recuperado no IdController = " + IdController.GetIdUser());
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    string sql = "UPDATE users SET nome = @nome, image = @image, cpf = @cpf, telefone = @telefone, cep = @cep, estado = @estado, cidade = @cidade, rua = @rua, numero = @numero , data = @data WHERE id = @id";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        byte[] image = user.getPhoto();
                        string nome = user.getNome();
                        string cpf = user.getCpf();
                        string telefone = user.getTelefone();
                        string cep = user.getAddress().getCep();
                        string estado = user.getAddress().getState();
                        string cidade = user.getAddress().getCity();
                        string rua = user.getAddress().getStreet();
                        string numero = user.getAddress().getNumberAddress();
                        DateOnly data = user.getData();
                        int id = IdController.GetIdUser();
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@cep", cep);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@cidade", cidade);
                        cmd.Parameters.AddWithValue("@rua", rua);
                        cmd.Parameters.AddWithValue("@numero", numero);
                        cmd.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro MySQL: " + ex.Message);
                    return false;
                }
            }

            public bool UserCadastroCompleto(int userId)
            {
                Createconnection();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                string query = @"
            SELECT nome, email, image, cpf, telefone , cep, estado, cidade, rua, numero
            FROM users
            WHERE id = @id";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            string[] campos = new string[]
                            {
                        reader["nome"]?.ToString(),
                        reader["email"]?.ToString(),
                        reader["image"]?.ToString(),
                        reader["cpf"]?.ToString(),
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


                return false; 
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
    image LONGBLOB,
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
                        byte[] hash = establishment.getHash();
                        byte[] salt = establishment.getSalt();
                        string cnpj = establishment.getCnpj();
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
                    Console.WriteLine("Código do erro: " + ex.Number);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro inesperado: " + ex.Message);
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
                                establishment.setId(reader.GetInt32("id"));
                                establishment.setCnpj(reader.GetString("cnpj"));
                                establishment.setHash(GetBytesFromReader(reader, "hash"));
                                establishment.setSalt(GetBytesFromReader(reader, "salt"));
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
                        byte[] image = establishment.getImage();
                        string nome = establishment.getNome();
                        string email = establishment.getEmail();
                        string telefone = establishment.getTelefone();
                        string cep = establishment.getAddressEstablishment().getCep();
                        string estado = establishment.getAddressEstablishment().getState();
                        string cidade = establishment.getAddressEstablishment().getCity();
                        string rua = establishment.getAddressEstablishment().getStreet();
                        string numero = establishment.getAddressEstablishment().getNumberAddress();
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
                    System.Diagnostics.Debug.WriteLine(ex.Message);
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


                return false; 
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
                                establishment.setId(reader.GetInt32("id"));
                                establishment.setNome(reader.GetString("nome"));
                                establishment.setEmail(reader.GetString("email"));
                                establishment.setHash(GetBytesFromReader(reader, "hash"));
                                establishment.setSalt(GetBytesFromReader(reader, "salt"));
                                establishment.setImage(GetBytesFromReader(reader, "image"));
                                establishment.setTelefone(reader.GetString("telefone"));
                                establishment.setCnpj(reader.GetString("cnpj"));
                                addressEstablishment.setCep(reader.GetString("cep"));
                                addressEstablishment.setState(reader.GetString("estado"));
                                addressEstablishment.setCity(reader.GetString("cidade"));
                                addressEstablishment.setStreet(reader.GetString("rua"));
                                addressEstablishment.setNumberAddress(reader.GetString("numero"));
                                establishment.setAddressEstablishment(addressEstablishment);
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
            public bool deleteEstablishmentBank()
            {
                Createconnection();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                String sql = "DELETE FROM establishment WHERE id = @id"; 
                try
                {
                    using(var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", IdController.GetIdEstablishment());
                        deleteCardapioBank();
                        // deleta o cardapio desse restaurante para não dar erro na chave estrangeira
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch(MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return false;
                }
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
            public bool deleteCardapioBank()
            {
                Createconnection();
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                String sql = "DELETE FROM cardapio WHERE idRestaurante = @idRestaurante";
                try
                {
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@idRestaurante", IdController.GetIdEstablishment());
                        // deletar o produtos
                        DeletarProdutoPeloRestaurante(connection);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return false;
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
    imagem LONGBLOB,
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
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    connection.ChangeDatabase(bancoDados);

                    string sql = "INSERT INTO produtos (nome, descricao, preco, categoria, imagem ,idCardapio) " +
                                 "VALUES (@nome, @descricao, @preco, @categoria, @imagem , @idCardapio)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto.getNome());
                        cmd.Parameters.AddWithValue("@descricao", produto.getDescricao());
                        cmd.Parameters.AddWithValue("@preco", produto.getPreco());
                        cmd.Parameters.AddWithValue("@categoria", produto.getCategoria());
                        cmd.Parameters.AddWithValue("@imagem", produto.getImagem());
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
            public bool AtualizarProduto(Produto produto)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    connection.ChangeDatabase(bancoDados);

                    string sql = "UPDATE produtos SET nome = @nome, descricao = @descricao, preco = @preco, categoria = @categoria, imagem = @imagem WHERE id = @id";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", produto.getNome());
                        cmd.Parameters.AddWithValue("@descricao", produto.getDescricao());
                        cmd.Parameters.AddWithValue("@preco", produto.getPreco());
                        cmd.Parameters.AddWithValue("@categoria", produto.getCategoria());
                        cmd.Parameters.AddWithValue("@imagem", produto.getImagem());
                        cmd.Parameters.AddWithValue("@id", produto.getId());
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

            public List<Produto> ConsultarProdutoPorIdCardapio(int id)
        {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    
                    List<Produto> produtos = new List<Produto>();
                string sql = "SELECT * FROM produtos WHERE idCardapio = @id";

                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                var produto = new Produto();
                                produto.setId(reader.GetInt32("id"));
                                produto.setNome(reader.GetString("nome"));
                                produto.setDescricao(reader.GetString("descricao"));
                                produto.setPreco(reader.GetDecimal("preco"));
                                produto.setCategoria(reader.GetString("categoria"));
                                produto.setImagem(reader["imagem"] as byte[]);
                                produtos.Add(produto);
                            }
                        }
                        return produtos;
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
            public List<Produto> GetProdutos()
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    List<Produto> produtos = new List<Produto>();
                    string sql = "SELECT * FROM produtos";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var produto = new Produto();
                                produto.setId(reader.GetInt32("id"));
                                produto.setNome(reader.GetString("nome"));
                                produto.setDescricao(reader.GetString("descricao"));
                                produto.setPreco(reader.GetDecimal("preco"));
                                produto.setCategoria(reader.GetString("categoria"));
                                produto.setImagem(reader["imagem"] as byte[]);
                                produtos.Add(produto);
                            }
                        }
                        return produtos;
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

            public Produto ConsultarProdutoPorId(int id)
            {
                try
                {
                    Createconnection();
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                   
                    string sql = "SELECT * FROM produtos WHERE id = @id";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var produto = new Produto();
                                produto.setId(reader.GetInt32("id"));
                                produto.setIdCardapio(reader.GetInt32("idCardapio"));
                                produto.setNome(reader.GetString("nome"));
                                produto.setDescricao(reader.GetString("descricao"));
                                produto.setPreco(reader.GetDecimal("preco"));
                                produto.setCategoria(reader.GetString("categoria"));
                                produto.setImagem(reader["imagem"] as byte[]);
                                return produto;
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

            public void DeletarProdutoPeloRestaurante(MySqlConnection connection)
            {
                try
                {
                    if(connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    string sql = "DELETE FROM produtos WHERE idCardapio = @idCardapio";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@idCardapio", IdController.GetIdEstablishment());
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao deletar produto: " + ex.Message);
                }
            }

            //pesquisar
            public List<Establishment> BuscarRestaurantes(string nome)
            {
                var estabelecimentos = new List<Establishment>();

                try
                {
                    Createconnection();

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    connection.ChangeDatabase(bancoDados);

                    string sql = @"SELECT id, nome, email, telefone, image, cep, estado, cidade, rua, numero 
                                    FROM establishment 
                                    WHERE LOWER(nome) LIKE @nome
                                    ";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@nome", $"%{nome.ToLower()}%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var est = new Establishment();
                                est.setId(reader.GetInt32("id"));
                                est.setNome(reader.GetString("nome"));
                                est.setEmail(reader.GetString("email"));
                                est.setTelefone(reader.GetString("telefone"));
                                est.setImage(GetBytesFromReader(reader, "image"));
                                var addressEstablishment = new AddressEstablishment();
                                addressEstablishment.setCep(reader.GetString("cep"));
                                addressEstablishment.setState(reader.GetString("estado"));
                                addressEstablishment.setCity(reader.GetString("cidade"));
                                addressEstablishment.setStreet(reader.GetString("rua"));
                                addressEstablishment.setNumberAddress(reader.GetString("numero"));
                                est.setAddressEstablishment(addressEstablishment);
                                estabelecimentos.Add(est);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao buscar restaurantes: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }

                return estabelecimentos;
            }

            public List<Establishment> BuscarRestaurantesProximos(string estado)
            {
                var estabelecimentos = new List<Establishment>();

                try
                {
                    Createconnection();

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    connection.ChangeDatabase(bancoDados);

                    string sql = @"SELECT id, nome, email, telefone, image, cep, estado, cidade, rua, numero 
                       FROM establishment 
                       WHERE LOWER(estado) LIKE @estado";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@estado", $"%{estado.ToLower()}%");  // <<< Corrigido aqui!

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var est = new Establishment();
                                est.setId(reader.GetInt32("id"));
                                est.setNome(reader.GetString("nome"));
                                est.setEmail(reader.GetString("email"));
                                est.setTelefone(reader.GetString("telefone"));
                                est.setImage(GetBytesFromReader(reader, "image"));

                                var addressEstablishment = new AddressEstablishment();
                                addressEstablishment.setCep(reader.GetString("cep"));
                                addressEstablishment.setState(reader.GetString("estado"));
                                addressEstablishment.setCity(reader.GetString("cidade"));
                                addressEstablishment.setStreet(reader.GetString("rua"));
                                addressEstablishment.setNumberAddress(reader.GetString("numero"));

                                est.setAddressEstablishment(addressEstablishment);

                                estabelecimentos.Add(est);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao buscar restaurantes: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }

                return estabelecimentos;
            }



            public List<Produto> BuscarTodosProdutos(string termo)
            {
                var produtos = new List<Produto>();

                try
                {
                    Createconnection();

                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    connection.ChangeDatabase(bancoDados);

                    string sql = @"
SELECT id, nome, descricao, preco, categoria, imagem
FROM produtos
WHERE LOWER(nome) LIKE @termo OR LOWER(categoria) LIKE @termo";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@termo", $"%{termo.ToLower()}%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var produto = new Produto();
                                produto.setId(reader.GetInt32("id"));
                                produto.setNome(reader.GetString("nome"));
                                produto.setDescricao(reader.GetString("descricao"));
                                produto.setPreco(reader.GetDecimal("preco"));
                                produto.setCategoria(reader.GetString("categoria"));
                                produto.setImagem(reader["imagem"] as byte[]);
                                produtos.Add(produto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao buscar produtos: " + ex.Message);
                }
                finally
                {
                    if (connection != null && connection.State != ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }

                return produtos;
            }

            public List<Produto> BuscarProdutosRestaurante(int idCardapio, string termo)
            {
                var produtos = new List<Produto>();

                try
                {
                    Createconnection();
                    connection.ChangeDatabase(bancoDados);

                    string sql = @"
            SELECT id, nome, descricao, preco, categoria, imagem
            FROM produtos
            WHERE idCardapio = @idCardapio
            AND (LOWER(nome) LIKE @termo OR LOWER(categoria) LIKE @termo)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@idCardapio", idCardapio);
                        cmd.Parameters.AddWithValue("@termo", $"%{termo.ToLower()}%");
                        connection.Open();

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var produto = new Produto();
                                produto.setId(reader.GetInt32("id"));
                                produto.setNome(reader.GetString("nome"));
                                produto.setDescricao(reader.GetString("descricao"));
                                produto.setPreco(reader.GetDecimal("preco"));
                                produto.setCategoria(reader.GetString("categoria"));
                                produto.setImagem(reader["imagem"] as byte[]);
                                produtos.Add(produto);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao buscar produtos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                return produtos;
            }
            public List<Establishment> ExibirRestaurantes()
            {
                var estabelecimentos = new List<Establishment>();

                try
                {
                    BancoDados.Createconnection();

                    if (BancoDados.connection.State != ConnectionState.Open)
                    {
                        BancoDados.connection.Open();
                    }

                    BancoDados.connection.ChangeDatabase(bancoDados);

                    string sql = @"SELECT * FROM establishment";

                    using (var cmd = new MySqlCommand(sql, BancoDados.connection))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var addressEstablishment = new AddressEstablishment();
                            var establishment = new Establishment();
                            establishment.setId(reader.GetInt32("id"));
                            establishment.setNome(reader.GetString("nome"));
                            establishment.setEmail(reader.GetString("email"));
                            establishment.setHash(GetBytesFromReader(reader, "hash"));
                            establishment.setSalt(GetBytesFromReader(reader, "salt"));
                            establishment.setImage(GetBytesFromReader(reader, "image"));
                            establishment.setTelefone(reader.GetString("telefone"));
                            establishment.setCnpj(reader.GetString("cnpj"));
                            addressEstablishment.setCep(reader.GetString("cep"));
                            addressEstablishment.setState(reader.GetString("estado"));
                            addressEstablishment.setCity(reader.GetString("cidade"));
                            addressEstablishment.setStreet(reader.GetString("rua"));
                            addressEstablishment.setNumberAddress(reader.GetString("numero"));
                            establishment.setAddressEstablishment(addressEstablishment);
                            estabelecimentos.Add(establishment);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao buscar restaurantes: " + ex.Message);
                }
                finally
                {
                    if (BancoDados.connection != null && BancoDados.connection.State != ConnectionState.Closed)
                    {
                        BancoDados.connection.Close();
                    }
                }

                return estabelecimentos;
            }
           

            // pedidos
            public void createPedidosTable()
            {
                string sql = @"
CREATE TABLE IF NOT EXISTS pedidos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idRestaurante INT NOT NULL,
    FOREIGN KEY (idRestaurante) REFERENCES establishment(id),
    idCliente INT NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES users(id),
    idProduto INT NOT NULL,
    FOREIGN KEY (idProduto) REFERENCES produtos(id),
    total DECIMAL(10,2) NOT NULL,
    forma_pagamento VARCHAR(20) NOT NULL,
    subtipo_pagamento VARCHAR(20),
    status VARCHAR(50) NOT NULL,
    tempo_estimado DATETIME NOT NULL,
    data_pedido DATETIME DEFAULT CURRENT_TIMESTAMP
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
            public void RegistrarPedido(Pedido pedido)
            {
                Createconnection();
                try
                {
                    if(connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    
                    // comprar um produto quem vai estar logado é o usuario então eu tenho que pegar o idRestaurante de alguma forma 
                    // idProduto , idCliente , IdRestaurante
                    string sql = "INSERT INTO pedidos (idRestaurante , idCliente , idProduto, total, forma_pagamento,subtipo_pagamento, status, data_pedido) VALUES (@idRestaurante , @idCliente , @idProduto ,@total, @forma_pagamento,@subtipo_pagamento, @status, @data_pedido)";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@idRestaurante", pedido.getIdRestaurante());
                        cmd.Parameters.AddWithValue("@idCliente", pedido.getIdCliente());
                        cmd.Parameters.AddWithValue("@idProduto", pedido.getIdProduto());
                        cmd.Parameters.AddWithValue("@total", pedido.getTotal());
                        cmd.Parameters.AddWithValue("@forma_pagamento", pedido.getPagamento().getTipo());
                        cmd.Parameters.AddWithValue("@subtipo_pagamento", pedido.getPagamento().getSubTipo());
                        cmd.Parameters.AddWithValue("@status", pedido.getStatus());
                        cmd.Parameters.AddWithValue("@data_pedido", pedido.getDataPedido());

                        
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao registrar pedido: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            public List<Pedido> ListarPedidos(int idEstabelecimento)
            {
                var pedidos = new List<Pedido>();

                try
                {
                    Createconnection();
                    connection.ChangeDatabase(bancoDados);

                    string sql = @"
            SELECT *
            FROM pedidos
            WHERE idEstabelecimento = @idEstabelecimento";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@idEstabelecimento", idEstabelecimento);
                        connection.Open();

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pedido = new Pedido();
                                pedido.setId(reader.GetInt32("id"));
                                pedido.setIdRestaurante(reader.GetInt32("idRestaurante"));
                                pedido.setIdCliente(reader.GetInt32("idCliente"));
                                pedido.setIdProduto(reader.GetInt32("idProduto"));
                                pedido.getPagamento().setTipo(reader.GetString("tipo"));
                                pedido.getPagamento().setSubTipo(reader.GetString("subtipo"));
                                pedido.setTotal(reader.GetDecimal("total"));
                                pedido.setStatus(reader.GetString("status"));
                                pedido.setTempoEntrega(reader.GetDateTime("tempo_estimado"));
                                pedido.setDataPedido(reader.GetDateTime("data_pedido"));
                                pedidos.Add(pedido);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Erro ao listar pedidos: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                return pedidos;
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





