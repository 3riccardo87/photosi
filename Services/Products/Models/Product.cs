using System.ComponentModel.DataAnnotations;

namespace Products.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        public List<int> Orders { get; set; }
    }
}
