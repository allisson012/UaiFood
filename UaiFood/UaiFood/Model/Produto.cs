using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    internal class Produto
    {
        private int id;
        private int idCardapio;
        private string nome;
        private string descricao;
        private decimal preco;
        private string categoria;
        private byte[] imagem;
        public Produto() { }
        public Produto(int id, string nome, string descricao, decimal preco, string categoria, byte[] imagem)
        {
            id = id;
            nome = nome;
            descricao = descricao;
            preco = preco;
            categoria = categoria;
            imagem = imagem;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setIdCardapio(int idCardapio)
        {
            this.idCardapio = idCardapio;
        }
        public int getIdCardapio()
        {
            return this.idCardapio;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setPreco(decimal preco)
        {
            this.preco = preco;
        }
        public decimal getPreco()
        {
            return this.preco;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
        public string getCategoria()
        {
            return this.categoria;
        }
        public void setImagem(byte [] imagem)
        {
            this.imagem = imagem;
        }
        public byte[] getImagem()
        {
            return this.imagem;
        }

    }
}

