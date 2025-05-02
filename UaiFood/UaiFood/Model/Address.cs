using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    class Address
    {
        public int cep;
        private String cidade;
        private String rua;
        private String estado;
        private int numero;
        public string uf { set; get; }
        public string localidade { set; get; }
        public string complemento { set; get; }
        public string bairro { set; get; }
        public string logradouro { set; get; }
        public void setCep(int cep)
        {
            this.cep = cep;
        }
        public int getCep()
        {
            return this.cep;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getCidade()
        {
            return this.cidade;
        }
        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public string getRua()
        {
            return this.rua;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public string getEstado()
        {
            return this.estado;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public int getNumero()
        {
            return this.numero;
        }
    }
}
