using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using KashanExpress.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace KashanExpress.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be between 1 to 50 characters", MinimumLength = 1)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Display Picture URL")]
        [ValidateNever]
        public string DisplayPictureUrl { get; set; }

        [Display(Name = "Product Price")]
        public double Price { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }



    }
}
