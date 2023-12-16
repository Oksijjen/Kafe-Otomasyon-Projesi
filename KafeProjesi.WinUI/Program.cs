using KafeProjesi.Bussiness.Abstract;
using KafeProjesi.Bussiness.Concrate;
using KafeProjesi.DataAccess.Abstract;
using KafeProjesi.DataAccess.Concrate.EntityFramework.repository;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing.Design;

namespace KafeProjesi.WinUI
{
    internal static class Program
    {
        private static void ConfigureService(ServiceCollection services)
        {
            services.AddTransient<frmLogin>();



            services.AddSingleton<IKullaniciBs,  KullaniciBs>();
            services.AddSingleton<IKullaniciRepository, EfKullaniciRepository>();

            services.AddSingleton<IUrunBs, UrunBs>();
            services.AddSingleton<IUrunRepository, EfUrunRepository>();



        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new ServiceCollection();

            ConfigureService(services);

            FormFactory.SetServiceProvider(services.BuildServiceProvider());




            Application.Run(FormFactory.CreatefrmLogin());
        }
    }
}