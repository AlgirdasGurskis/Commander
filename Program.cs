using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//
//  Note: Twis C# MVC web API REST // have GET 
//
// https://www.youtube.com/watch?v=fmvcAzHpsk8
// >dotnet run  // execute app, and after that run Postman 
//       postman: algisgenesis@gmail.com	Algirdas1959
//       [LaunchPad] + http://localhost:5000/api/commands/4 [Send]
//
namespace Commander
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
