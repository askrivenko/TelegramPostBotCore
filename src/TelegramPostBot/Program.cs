using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;


namespace TelegramPostBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
			

			var configurations = new ConfigurationBuilder()
						.AddCommandLine(args)
						.Build();


			var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
				.UseUrls(args[0])
				.Build();

            host.Run();
        }
    }
}
