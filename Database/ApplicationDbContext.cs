using graphql_dotnet.Models.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace graphql_dotnet.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}