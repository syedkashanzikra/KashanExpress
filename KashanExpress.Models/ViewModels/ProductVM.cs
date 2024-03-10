using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace KashanExpress.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; } =new Product();

        [ValidateNever]
        public IEnumerable<Product> Products { get; set;} = new List<Product>();

        [ValidateNever]
        public IEnumerable<SelectListItem> Categories { get; set; } //the categorie come from the database context file name

    }
}
