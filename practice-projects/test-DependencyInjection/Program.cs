using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace DITest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddSingleton<Model.IUserService, Model.User>();
            services.AddSingleton<Presenter.User>();
            //services.AddSingleton<Model.User>();
            services.AddSingleton<Database>();
            services.AddTransient<MyClass>();

            var serviceProvider = services.BuildServiceProvider();
            Global.ServiceLocator.ServiceProvider = serviceProvider;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
