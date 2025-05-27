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
        private string nome;
        private string email;
        private byte[] image;
        private byte[] hash;
        private byte[] salt;
        private string cnpj;
        private AddressEstablishment addressEstablishment;
        private List<Cardapio> cardapio;
        private string telefone;

        public int getId() => id;
        public void setId(int value) => id = value;

        public string getNome() => nome;
        public void setNome(string value) => nome = value;

        public string getEmail() => email;
        public void setEmail(string value) => email = value;

        public byte[] getHash() => hash;
        public void setHash(byte[] value) => hash = value;

        public byte[] getSalt() => salt;
        public void setSalt(byte[] value) => salt = value;

        public byte[] getImage() => image;
        public void setImage(byte[] value) => image = value;

        public string getCnpj() => cnpj;
        public void setCnpj(string value) => cnpj = value;

        public AddressEstablishment getAddressEstablishment() => addressEstablishment;
        public void setAddressEstablishment(AddressEstablishment value) => addressEstablishment = value;

        public List<Cardapio> getCardapio() => cardapio;
        public void setCardapio(List<Cardapio> value) => cardapio = value;

        public string getTelefone() => telefone;
        public void setTelefone(string value) => telefone = value;
    }
}
