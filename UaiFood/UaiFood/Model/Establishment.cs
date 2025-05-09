using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    class Establishment
    {
        private int _id;
        private string _nome;
        private string _email;
        private byte[] _hash;
        private byte[] _salt;
        private string _cnpj;
        private Address _address;
        private List<Cardapio> _cardapio;
        private string _telefone;

        public int GetId() => _id;
        public void SetId(int value) => _id = value;

        public string GetNome() => _nome;
        public void SetNome(string value) => _nome = value;

        public string GetEmail() => _email;
        public void SetEmail(string value) => _email = value;

        public byte[] GetHash() => _hash;
        public void SetHash(byte[] value) => _hash = value;

        public byte[] GetSalt() => _salt;
        public void SetSalt(byte[] value) => _salt = value;

        public string GetCnpj() => _cnpj;
        public void SetCnpj(string value) => _cnpj = value;

        public Address GetAddress() => _address;
        public void SetAddress(Address value) => _address = value;

        public List<Cardapio> GetCardapio() => _cardapio;
        public void SetCardapio(List<Cardapio> value) => _cardapio = value;

        public string GetTelefone() => _telefone;
        public void SetTelefone(string value) => _telefone = value;
    }
}
