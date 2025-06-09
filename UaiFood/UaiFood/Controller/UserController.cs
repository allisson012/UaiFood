using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Model;
using UaiFood.View;

namespace UaiFood.Controller
{
    class UserController
    {
        public void createUser(String email, String senha)
        {
            User u = new User();
            EmailController emailController = new EmailController();
            Boolean validoEmail = emailController.ValidarEmail(email);
            if (validoEmail)
            {
                u.setEmail(email);
            }
            PasswordController passwordController = new PasswordController();
            u = passwordController.VerificarSenha(senha, u);
            System.Diagnostics.Debug.WriteLine(u.getHash);
            if (u.getHash() == null)
            {
                MessageBox.Show(
                    "A senha deve conter pelo menos 8 caracteres, 1 letra maiúscula, 1 letra minúscula e 1 número",
                    "Senha inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            if (u.getEmail() != null && u.getHash() != null)
            {
                System.Diagnostics.Debug.WriteLine("email é valido");
                var bancoDados = new BancoDados();
                bool userRegister = bancoDados.RegisterUserBank(u);
                if (userRegister)
                {
                    MessageBox.Show("Usuario cadastrado com sucesso");
                    var telaCriarPerfilCliente = new TelaCriarPerfilCliente();
                    telaCriarPerfilCliente.Show();
                    var telaCadastro = new TelaCadastro();
                    telaCadastro.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuario");
                }
            }
            else
            {
                MessageBox.Show("Insira um email ou senha Validas");
            }
        }
        public User consultUser(int id)
        {
            var bancoDados = new BancoDados();
            var user = bancoDados.findUserById(id);
            return user;
        }
        public void deleteUser(int id)
        {
            var bancoDados = new BancoDados();
            bool deletado = bancoDados.deleteUserBank(id);
            if (deletado)
            {
                MessageBox.Show("Usuario deletado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao deletar usuario");
            }
        }
        public void UserLogin(string email, string senha)
        {
            var bancoDados = new BancoDados();
            User u = bancoDados.getSenhaUserBank(email);
            if (u != null)
            {
                var passwordController = new PasswordController();
                bool senhaValida = passwordController.compareSenha(senha, u);
                if (senhaValida)
                {
                    MessageBox.Show("Usuario logado com sucesso");
                    IdController.SetIdUser(u.getUserId());
                    System.Diagnostics.Debug.WriteLine("Id logado: " + u.getUserId());
                    if (!bancoDados.UserCadastroCompleto(u.getUserId()))
                    {
                        var telaCriarPerfilCliente = new TelaCriarPerfilCliente();
                        telaCriarPerfilCliente.Show();
                        var telaLogin = new TelaLogin();
                        telaLogin.Close();
                    }
                    else
                    {
                        var telaPrincipalCliente = new TelaPrincipalCliente();
                        telaPrincipalCliente.Show(); 
                        bool retorno = bancoDados.BuscarIdNaTabela(u.getUserId());
                        System.Diagnostics.Debug.WriteLine("retorno = ", retorno);
                        if (!retorno)
                        {
                            TelaQrCode telaQrCode = new TelaQrCode();
                            telaQrCode.Show();
                        }
                        
                        var telaLogin = new TelaLogin();
                        telaLogin.Close();
                    }
                }
                else
                {
                    MessageBox.Show("erro ao logar usuario email ou senha incorretos");
                }
            }
            else
            {
                MessageBox.Show("email do usuario não cadastrado no banco");
            }
        }

        public Boolean UpdatePassword(string email, string password)
        {
            var bancoDados = new BancoDados();
            PasswordController passwordController = new PasswordController();
            User u = bancoDados.getSenhaUserBank(email);
            byte[] hash = u.getHash();
            u = passwordController.VerificarSenha(password, u);
            if (hash != u.getHash())
            {
                bool sucesso = bancoDados.RegisterNewPassword(u);
                if (sucesso)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("A senha não pode ser a mesma da anterior!");
                }
            }

            return false;



        }
        public void createPerfilUser(int id, string nome, string cpf, string street, string state, string city, string cep, string telephone, string numberAddress, byte[] image, DateOnly data)
        {
            var address = new AddressUser();
            string cep02 = Regex.Replace(cep, @"\D", "");
            address.setCep(cep02);
            address.setState(state);
            address.setCity(city);
            address.setStreet(street);
            address.setNumberAddress(numberAddress);
            var user = new User();
            user.setNome(nome);
            string telefone = Regex.Replace(telephone, @"\D", "");
            user.setTelefone(telefone);
            user.setAddress(address);
            user.setPhoto(image);
            string cpf02 = Regex.Replace(cpf, @"\D", "");
            user.setCpf(cpf02);
            user.setData(data);
            var bd = new BancoDados();
            bool criadoPerfil = bd.completePerfilUser(user);
            if (criadoPerfil)
            {                
                MessageBox.Show("Perfil concluido com sucesso!");
                TelaPrincipalCliente telaPrincipalCliente = new TelaPrincipalCliente();
                telaPrincipalCliente.Show();
                bool retorno = bd.BuscarIdNaTabela(user.getUserId());
                System.Diagnostics.Debug.WriteLine("retrono = ",retorno);
                if (!retorno)
                {
                    TelaQrCode telaQrCode = new TelaQrCode();
                    telaQrCode.Show();
                    var telaLogin = new TelaCriarPerfilCliente();
                    telaLogin.Close();
                }
            }
            else
            {
                MessageBox.Show("Erro ao concluir cadastrado do perfil");
            }

        }
        public bool deleteUser()
        {
            BancoDados bd = new BancoDados();
            return bd.deleteUserBank(IdController.GetIdUser());
        }
    }
}
