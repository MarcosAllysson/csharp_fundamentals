using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [MaxLength(60, ErrorMessage = "Between 3 and 60 characters only")]
        [MinLength(3, ErrorMessage = "Between 3 and 60 characters only")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Max 1024 characters only.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be higher than 1")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid category")]
        public int CategoryId { get; set; }

        // Propriedade de referência caso queira dados da categoria além do ID.
        public Category Category { get; set; }
    }
}