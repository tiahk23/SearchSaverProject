using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.ViewModels
{
    public class AddProductViewModel
    {
        [Required(ErrorMessage = "Store name is required.")]
        public string Store { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Brand name is required.")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

    }
}
