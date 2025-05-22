
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
        private DateOnly data;
        private AddressUser addressUser;
        private string telefone;
        private string cpf;
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
        public void setPhoto(byte[] photo)
        {
            this.photo = photo;
        }
        public byte[] getPhoto()
        {
            return this.photo;
        }
        public DateOnly getData()
        {
            return this.data;
        }
        public void setData(DateOnly data)
        {
            this.data = data;
        }
        // pensando em fazer na hora de setar recebendo uma string e um get retorna a data ja em string
        public int getUserId()
        {
            return this.UserId;
        }
        public void setId(int id)
        {
            this.UserId = id;
        }
        public AddressUser getAddress()
        {
            return this.addressUser;
        }
        public void setAddress(AddressUser addressUser)
        {
            this.addressUser = addressUser;
        }
        public String getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }


    }
}
