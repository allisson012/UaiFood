using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiFood.Model;

namespace UaiFood.Controller
{
     class CarrinhoControllerStatic
    {
        private static List<Produto> produtos;
        private static CarrinhoControllerStatic instance;
        private  CarrinhoControllerStatic()
        {
            produtos = new List<Produto>();
        }
        public static CarrinhoControllerStatic getInstance()
        {
            if (instance == null)
            {
                instance = new CarrinhoControllerStatic();
            }
            return instance;
        }
        public void addProduto(Produto produto)
        {
            produtos.Add(produto);
        }
        public List<Produto> getProdutos()
        {
            return produtos;
        }
        public bool limparCarrinho()
        {
            produtos.Clear();
            if(produtos == null){
                return true;
            }
            return false;
        }
    }
}
