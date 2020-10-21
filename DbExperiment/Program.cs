using System;
using DbExperiment.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.Configuration;
using Serilog;




namespace DbExperiment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Serilog
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .WriteTo.Console()
                .CreateLogger();
            

            Log.Information("Application Starting Up");
            Log.Information("This for a test.");


            //auto apply migrations
            var builder = CreateHostBuilder(args).Build();
            

            using (var scope = builder.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                    Log.Information("Migrations Complete");
                }
                catch (Exception ex)
                {
                    Log.Error("Fuck up on DB Justin", ex);
                }
            }

            builder.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }
    }
}