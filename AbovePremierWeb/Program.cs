using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AbovePremierWeb.DAOs;
using AbovePremierWeb.Models;

namespace AbovePremierWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connString = "Server=localhost;Database=abovepremiere;uid=root;Password=;";
            DBConn.getInstance().connect(connString);
            MiMain();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void MiMain()
        {

            KeyDAO.getInstance().generarKeys();

        }
    }
}
