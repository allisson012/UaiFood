using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UaiFood.Model;

namespace UaiFood.Controller
{
    class addressController
    {
        public async Task<Address> viaCepBuscaAsync(string cep)
         {
            if (string.IsNullOrWhiteSpace(cep))
            {
                MessageBox.Show("Campo está vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    cep = cep.Trim().Replace("-", "");
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    var retorno = JsonSerializer.Deserialize<Address>(json);
                    if (retorno.Cep == null)
                    {
                        MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return null;
                    }

                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                return null;
            }
        }
    }
    
}
