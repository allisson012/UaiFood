using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    internal class Carrinho
    {
        public List<Produto> Produtos { get; private set; } = new List<Produto>();
        public Carrinho()
        {
            Produtos = new List<Produto>();
        }
        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }
        public decimal CalcularTotal()
        {
            return Produtos.Sum(p => p.getPreco());
        }
        public void LimparCarrinho()
        {
            Produtos.Clear();
        }
    }
}
