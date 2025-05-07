using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    class Establishment
    {
        private int id;
        private String nome;
        private String email;
        private String senha;
        private long cnpj;
        private int cep;
        private List<Cardapio> cardapio;
        private long telefone;
    }
}
