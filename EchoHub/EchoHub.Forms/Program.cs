using EchoHub.Forms.Core;

namespace EchoHub.Forms.Interface
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
            ApplicationConfiguration.Initialize();
            Client.Start();
            Application.Run(new AccountForm());
        }
    }
}