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
    class EstablishmentController
    {
        public void createEstablishment(String cnpj, String senha)
        {
            System.Diagnostics.Debug.WriteLine("cnpj = " + cnpj);
            if (!DocumentController.ValidarCNPJ(cnpj))
            {
                MessageBox.Show("Erro ao criar Conta do restaurante: CNPJ inválido");
                return;
            }
            var passwordController = new PasswordController();
            var establishment = new Establishment();
            establishment = passwordController.VerificarSenha(senha, establishment);
            if (establishment.getHash() != null)
            {
                System.Diagnostics.Debug.Write(establishment.getHash().ToString());
                System.Diagnostics.Debug.Write(establishment.getSalt().ToString());
                establishment.setCnpj(cnpj);
                var bancoDados = new BancoDados();
                bool establishmentCriado = bancoDados.CreateEstablishmentBank(establishment);
                if (establishmentCriado)
                {
                    System.Diagnostics.Debug.WriteLine("id salvo = " + IdController.GetIdEstablishment());
                    MessageBox.Show("Restaurante criado com sucesso");
                    var telaCriarPerfilRestaurante = new TelaCriarPerfilRestaurante();
                    telaCriarPerfilRestaurante.Show();
                    var telaLoginRestaurante = new TelaLoginRestaurante();
                    telaLoginRestaurante.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao criar Conta do restaurante");

                }
            }
            else
            {
                MessageBox.Show("Erro ao criar Conta do restaurante Senha invalida");
            }
        }

        public void createPerfilEstablishment(int id ,string nameRestaurante, string email, string street, string state, string city, string cep, string telephone, string numberAddress , byte[] image)
        {
            var address = new AddressEstablishment();
            string cep02 = Regex.Replace(cep, @"\D", "");
            address.setCep(cep02);
            address.setState(state);
            address.setCity(city);
            address.setStreet(street);
            address.setNumberAddress(numberAddress);
            var establishment = new Establishment();
            establishment.setNome(nameRestaurante);
            establishment.setId(id);
            establishment.setEmail(email);
            string telefone = Regex.Replace(telephone, @"\D", "");
            establishment.setTelefone(telefone);
            establishment.setAddressEstablishment(address);
            establishment.setImage(image);
            var bd = new BancoDados();
            bool criadoPerfil = bd.completePerfilRestaurante(establishment);
            if (criadoPerfil)
            {
                MessageBox.Show("Perfil concluido com sucesso!");
                var telaPrincipalRestaurante = new TelaPrincipalRestaurante();
                telaPrincipalRestaurante.Show();
                var telaCriarPerfilRestaurante = new TelaCriarPerfilRestaurante();
                telaCriarPerfilRestaurante.Close();
            }
            else
            {
                MessageBox.Show("Erro ao concluir cadastrado do perfil");
            }

        }

        public bool loginEstablishment(string cnpj, string senha)
        {
            var bancoDados = new BancoDados();
            Establishment establishment = bancoDados.getSenhaEstablishmentBank(cnpj);
            if (establishment != null)
            {
                var passwordController = new PasswordController();
                bool senhaValida = passwordController.compareSenhaForEstablishment(senha, establishment);
                if (senhaValida)
                {
                    MessageBox.Show("Restaurante logado com sucesso");
                    IdController.SetIdEstablishment(establishment.getId());
                    if (bancoDados.EstabelecimentoCadastroCompleto(IdController.GetIdEstablishment()))
                    {
                        return true;
                        // var telaPrincipal = new TelaPrincipalCliente();
                        // telaPrincipal.Show();
                    }
                    else
                    {
                        var telaCriarPerfilRestaurante = new TelaCriarPerfilRestaurante();
                        telaCriarPerfilRestaurante.Show();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("erro ao logar Restaurante cnpj ou senha incorretos");
                }
            }
            else
            {
                MessageBox.Show("estabelecimento não encontrado");
            }
            return false;
        }
        public bool deleteEstablishment()
        {
            var bd = new BancoDados();
            bool retorno = bd.deleteEstablishmentBank();
            return retorno;
        }

        //pesquisar
        public List<Establishment> PesquisarRestaurantes(string nome)
        {
            var banco = new BancoDados();
            return banco.BuscarRestaurantes(nome);
        }
        public List<Produto> PesquisarProdutos(int idCardapio, string termo)
        {
            var banco = new BancoDados();
            return banco.BuscarProdutosRestaurante(idCardapio, termo);
        }

    }
}
