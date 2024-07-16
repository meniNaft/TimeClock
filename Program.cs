using TimeClock.Models;
using TimeClock.Services;
using System.Threading;
using TimeClock.DAL;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

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
            NavigationService.ShowForm(FormsEnum.LOGIN_FORM);
            Application.Run();
        }

       
    }
}