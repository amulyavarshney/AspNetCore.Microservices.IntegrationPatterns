using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace Api.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // making Ocelot aware of re-route configurations
            builder.Configuration.AddJsonFile("configuration.json", optional: false);

            builder.Services.AddOcelot();

            var app = builder.Build();

            // Configure method cannot be made async Task
            app.UseOcelot().GetAwaiter().GetResult();

            app.MapGet("/", () => "Api Gateway");

            app.Run();
        }
    }
}