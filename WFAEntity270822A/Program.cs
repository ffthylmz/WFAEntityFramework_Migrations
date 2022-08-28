using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WFAEntity270822A.Classes;

namespace WFAEntity270822A
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

            var builder = new HostBuilder().ConfigureServices((services) =>
            {
                services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer("Server=ASUS\\SQLEXPRESS;Database=CodeFirstOkulDB; integrated security=True ")
                );
            });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var myDBContext = services.GetRequiredService<AppDBContext>();
                Application.Run(new Form1(myDBContext));
            }





        }
    }
}