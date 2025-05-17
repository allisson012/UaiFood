using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Model
{
    class AddressEstablishment
    {
        private string cep;
        private string state;
        private string city;
        private string numberAddress;
        private string street;

        public void setCep(string cep)
        {
            this.cep = cep;
        }
        public string getCep()
        {
            return this.cep;
        }
        public void setState(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return this.state;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return this.city;
        }
        public void setNumberAddress(string numberAddress)
        {
            this.numberAddress = numberAddress;
        }
        public string getNumberAddress()
        {
            return this.numberAddress;
        }
        public void setStreet(string street)
        {
            this.street = street;
        }
        public string getStreet()
        {
            return this.street;
        }
    }
}
