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
        public async void viaCepBusca(string cep)
        {
            
            if (string.IsNullOrWhiteSpace(cep))
            {
                MessageBox.Show("Campo está vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
                    if (retorno.cep == null)
                    {
                        MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    string estado = retorno.uf;
                    string cidade = retorno.localidade;
                    string bairro = retorno.bairro;
                    string complemento = retorno.complemento;
                    string endereco = retorno.logradouro;
                    System.Diagnostics.Debug.WriteLine(estado);
                    System.Diagnostics.Debug.WriteLine(cidade);
                    System.Diagnostics.Debug.WriteLine(bairro);
                    System.Diagnostics.Debug.WriteLine(complemento);
                    System.Diagnostics.Debug.WriteLine(endereco);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
    
}
