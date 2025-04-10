using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    internal class LoginGoogleController
    {
        // Escopos que você precisa, por exemplo: email e perfil
        private static readonly string[] Scopes = { "email", "profile" };

        /// <summary>
        /// Inicia o fluxo de autenticação com o Google e retorna as credenciais do usuário autenticado.
        /// </summary>
        public async Task<UserCredential> FazerLoginGoogleAsync()
        {
            var clientId = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_ID");
            var clientSecret = Environment.GetEnvironmentVariable("GOOGLE_CLIENT_SECRET");

            if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(clientSecret))
            {
                throw new Exception("Client ID ou Client Secret não configurados nas variáveis de ambiente.");
            }

            var clientSecrets = new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            };

            UserCredential credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                clientSecrets,
                Scopes,
                "user",
                CancellationToken.None,
                new FileDataStore("Token")
            );

            return credential;
        }
    }
}
