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

        public int GetId() => id;
        public void SetId(int value) => id = value;

        public string GetNome() => nome;
        public void SetNome(string value) => nome = value;

        public string GetEmail() => email;
        public void SetEmail(string value) => email = value;

        public byte[] GetHash() => hash;
        public void SetHash(byte[] value) => hash = value;

        public byte[] GetSalt() => salt;
        public void SetSalt(byte[] value) => salt = value;

        public byte[] GetImage() => image;
        public void SetImage(byte[] value) => image = value;

        public string GetCnpj() => cnpj;
        public void SetCnpj(string value) => cnpj = value;

        public AddressEstablishment GetAddressEstablishment() => addressEstablishment;
        public void SetAddressEstablishment(AddressEstablishment value) => addressEstablishment = value;

        public List<Cardapio> GetCardapio() => cardapio;
        public void SetCardapio(List<Cardapio> value) => cardapio = value;

        public string GetTelefone() => telefone;
        public void SetTelefone(string value) => telefone = value;
    }
}
