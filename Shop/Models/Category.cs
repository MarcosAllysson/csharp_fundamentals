using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [MaxLength(60, ErrorMessage = "Between 3 and 60 characters only")]
        [MinLength(3, ErrorMessage = "Between 3 and 60 characters only")]
        public string Title { get; set; }
    }
}