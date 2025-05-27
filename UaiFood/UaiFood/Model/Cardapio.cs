using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    class Cardapio
    {
        private List<Produto> produtos;
        private int idEstabelecimento;
        public void setProdutos(List<Produto> produtos)
        {
            this.produtos = produtos;
        }
    }
}
