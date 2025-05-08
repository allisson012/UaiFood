using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
        public byte[] Imagem { get; set; }

        public Produto() { }

        public Produto(int id, string nome, string descricao, decimal preco, string categoria, byte[] imagem)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Categoria = categoria;
            Imagem = imagem;
        }
    }
}

