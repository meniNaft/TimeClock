using TimeClock.Models;
using TimeClock.Services;
using System.Threading;
using TimeClock.DAL;
using System.Configuration;

namespace TimeClock
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
            //var res = DbContext.MakeQuery("select * from dbo.Employees");
            NavigationService navigationService = new NavigationService();
            Application.Run();
        }

       
    }
}