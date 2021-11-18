using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [MaxLength(20, ErrorMessage = "Between 3 and 20 characters only")]
        [MinLength(3, ErrorMessage = "Between 3 and 20 characters only")]
        public string Username { get; set; }


        [Required(ErrorMessage = "This field is mandatory")]
        [MaxLength(20, ErrorMessage = "Between 3 and 20 characters only")]
        [MinLength(3, ErrorMessage = "Between 3 and 20 characters only")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}