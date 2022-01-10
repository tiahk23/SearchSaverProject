using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SearchSaver.ViewModels
{
    public class AddSearchViewModel
    {
        [Required(ErrorMessage = "Search is required.")]
        public string SearchQuery { get; set; }
    }
}
