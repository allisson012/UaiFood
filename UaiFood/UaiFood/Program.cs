using UaiFood.BancoDeDados;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;
using UaiFood.Model;
using UaiFood.View;

namespace UaiFood
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BancoDados bd = new BancoDados();
            bd.createBank();
            bd.createTableUser();
            bd.createTableEstablishment();
            bd.createCardapioTable();
            bd.createProductTable();
            bd.createPedidosTable();
            bd.createTelegramTable();

            // Executa o bot em paralelo.
            Task.Run(() => TelegramController.RunBotAsync());

            ApplicationConfiguration.Initialize();
            Application.Run(new TelaInicial());
        }

    }
}