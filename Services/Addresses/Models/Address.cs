using System.ComponentModel.DataAnnotations;

namespace Addresses.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<int> Orders { get; set; }
    }
}
