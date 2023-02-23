namespace Booking.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            var app = builder.Build();

            app.MapGet("/", () => "Booking Service");
            app.MapControllers();

            app.Run();
        }
    }
}