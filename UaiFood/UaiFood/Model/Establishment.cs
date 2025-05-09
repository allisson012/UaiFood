using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    class Establishment
    {
        private int id { set; get;}
        private String nome { set; get;}
        private String email { set; get; }
        private byte [] hash { set; get; }
        private byte [] salt { set; get; }
        private String cnpj { set; get; }
        private Address address { set; get; }
        private List<Cardapio> cardapio { set; get; }
        private String telefone { set; get; }
        
    }
}
