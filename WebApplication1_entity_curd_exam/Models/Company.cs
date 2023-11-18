using System.ComponentModel.DataAnnotations;

namespace WebApplication1_entity_curd_exam.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        
    }
}
