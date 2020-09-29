using System.Collections.Generic;
using graphql_dotnet.Database;
using graphql_dotnet.Models.DbEntities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace graphql_dotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Seed data.
            var host = CreateHostBuilder(args).Build();

            using (IServiceScope scope = host.Services.CreateScope())
            {
                ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                context.Departments.Add(
                  new Department
                  {
                      Name = "D1",
                      Employees = new List<Employee>{
                          new Employee{
                              Name = "Empl1"
                          },
                          new Employee{
                              Name = "Empl2"
                          }
                      }
                  }
                );

                context.SaveChanges();
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
