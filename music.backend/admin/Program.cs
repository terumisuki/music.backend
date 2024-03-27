using business.Albums;
using business.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.Design.Serialization;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace admin
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

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: true);
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<IAlbumSearcher, AlbumSearcher>();
                    services.AddDbContext<AlxLibraryContext>(options =>
                                    options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                })
                .Build();
            var services = host.Services;

            Application.Run(new Form1(services));
        }
    }
}