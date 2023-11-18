using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1_entity_curd_exam.Models
{
    public class Product
    {
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        [ForeignKey("CompanyId")]
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

    }
}
