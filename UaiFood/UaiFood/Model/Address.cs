using System.Text.Json.Serialization;

public class Address
{
    [JsonPropertyName("cep")]
    public string Cep { get; set; }

    [JsonPropertyName("logradouro")]
    public string Rua { get; set; }

    [JsonPropertyName("bairro")]
    public string Bairro { get; set; }

    [JsonPropertyName("localidade")]
    public string Cidade { get; set; }

    [JsonPropertyName("uf")]
    public string Estado { get; set; }

    [JsonPropertyName("complemento")]
    public string Complemento { get; set; }
}
