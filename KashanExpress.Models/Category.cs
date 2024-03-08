
using System.ComponentModel.DataAnnotations;

namespace KashanExpress.Models
{
    public class Category
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Name can be min to 3 to 15")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Description can be min to 10 to 100")]
        [Display(Name = "Category Description")]
        public string Description { get; set; }


        public DateTime CategoryAdded { get; set; } = DateTime.Now;


    }
}
