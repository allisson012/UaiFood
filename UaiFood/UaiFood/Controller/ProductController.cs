using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UaiFood.Model;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;

namespace UaiFood.Controller
{
    class ProductController
    {
        public bool createProduct(string nome, string descricao, decimal preco, string categoria, byte[] imagem)
        {
            var produto = new Produto();
            produto.setNome(nome);
            produto.setDescricao(descricao);
            produto.setPreco(preco);
            produto.setCategoria(categoria);
            produto.setImagem(imagem);

            var banco = new BancoDados();
            bool cadastrado = banco.CadastrarProduto(produto);

            if (cadastrado)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                return true;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produto.");
                return false;
            }
        }
               
        public Produto consultProduct(int id)
        {
            var banco = new BancoDados();
            Produto produto = new Produto(); // resolvendo conflito
                                             //banco.ConsultarProdutoPorId(id);



            if (produto == null)
                MessageBox.Show("Produto não encontrado.");

            return produto;
        }

        public void deleteProduct(int id)
        {
            var banco = new BancoDados();
            bool deletado = true;
            //banco.DeletarProduto(id);

            if (deletado)
                MessageBox.Show("Produto deletado com sucesso!");
            else
                MessageBox.Show("Produto não encontrado ou erro ao deletar.");
        }

        public List<Produto> listProducts()
        {
            // var banco = new BancoDados();
            //   List<Produto> produtos = banco.ListarProdutos();

            // if (produtos.Count == 0)
            //   MessageBox.Show("Nenhum produto encontrado.");

            //  return produtos;
            //  }
            return null;
        }
        public void updateProduct(int id, string nome, string descricao, decimal preco, string categoria, byte[] imagem)
        {
            var produto = new Produto();
            produto.setId(id);               
            produto.setNome(nome);
            produto.setDescricao(descricao);
            produto.setPreco(preco);
            produto.setCategoria(categoria);
            produto.setImagem(imagem);

            var banco = new BancoDados();
            bool atualizado = banco.AtualizarProduto(produto);

            if (atualizado)
                MessageBox.Show("Produto atualizado com sucesso!");
            else
                MessageBox.Show("Erro ao atualizar produto.");
        }

    }
}

