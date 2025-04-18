
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
   
    class User
    {
        private String nome;
        private String email;
        int UserId;
        private int idade;
        private byte[] photo;
        private byte[] hash;
        private byte[] salt;
        private Address address; 
        private long cpf;
        public String getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public String getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public byte[] getHash()
        {
            return this.hash;
        }
        public void setHash(byte[] hash)
        {
            this.hash = hash;
        }
        public byte[] getSalt()
        {
            return this.salt;
        }
        public void setSalt(byte[] salt)
        {
            this.salt = salt;
        }
        public int getUserId()
        {
            return this.UserId;
        }
        public void setId(int id)
        {
            this.UserId = id;
        }
        public Address getAddress()
        {
            return this.address;
        }
        public void setAddress(Address address)
        {
            this.address = address;
        }
        public long getCpf()
        {
            return this.cpf;
        }
        public void setCpf(long cpf)
        {
            this.cpf = cpf;
        }


    }
}
