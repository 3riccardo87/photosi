using System.ComponentModel.DataAnnotations;

namespace Orders.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public int Address_Id { get; set; }
        [Required]
        public List<int> Products { get; set; }
    }
}
