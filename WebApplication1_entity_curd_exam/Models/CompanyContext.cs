using System.Data.Entity;

namespace WebApplication1_entity_curd_exam.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) :base(options)
        {
                
        }
    }
}
