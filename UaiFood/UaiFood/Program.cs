using UaiFood.BancoDeDados;
using UaiFood.BancoDeDados.UaiFood.BancoDeDados;
using UaiFood.Controller;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            BancoDados bd = new BancoDados();
            bd.createBank();
            bd.createTable();
            bd.createProductTable();
            bd.createCardapioTable();
            bd.createTableEstablishment();
            ApplicationConfiguration.Initialize();
            TelaLogin telaLogin = new TelaLogin();
            Application.Run(telaLogin);

        }
    }
}