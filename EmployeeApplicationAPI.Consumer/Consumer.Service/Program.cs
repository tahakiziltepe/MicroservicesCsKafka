using Consumer.Database;
using Microsoft.EntityFrameworkCore;

namespace Consumer.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddDbContext<EmployeeReportDbContext>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=microservicescskafka;Integrated Security=True;"),
                ServiceLifetime.Singleton
            );
            builder.Services.AddHostedService<Worker>();

            var host = builder.Build();
            host.Run();
        }
    }
}