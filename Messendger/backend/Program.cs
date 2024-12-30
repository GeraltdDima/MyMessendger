using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        IHostBuilder hostBuilder = CreateHostBuilder(args);
        IHost host = hostBuilder.Build();
        
        await host.RunAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder =>
        {
            builder.UseStartup<Startup>();
        });
    }
}