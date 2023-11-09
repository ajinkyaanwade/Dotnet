using Microsoft.EntityFrameworkCore;

namespace WebApplication_Sql_Repositary.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
