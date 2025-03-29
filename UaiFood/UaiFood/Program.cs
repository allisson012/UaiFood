using UaiFood.Controller;

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
            EmailController e = new EmailController();
            e.ValidarEmail("allisson@gmail.com");
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaLogin());
        }
    }
}