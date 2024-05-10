using System.ComponentModel.DataAnnotations;

namespace Users.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        public List<int> Orders { get; set; }

    }
}
