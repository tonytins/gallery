using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Tonytins.Api
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
                    if (!Debugger.IsAttached)
                        webBuilder.UseUrls(new string[] { "http://*", "https://*" });

                    webBuilder.UseStartup<Startup>();
                });
    }
}
