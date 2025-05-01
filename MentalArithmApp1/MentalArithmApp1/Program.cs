using System.Security.Cryptography.X509Certificates;
using DataClasses;

namespace MentalArithmApp1
{
    public static class Program
    {
        public static Training training = new();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}