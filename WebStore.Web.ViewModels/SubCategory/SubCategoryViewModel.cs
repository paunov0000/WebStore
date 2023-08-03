using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebStore.Common.EntityValidationConstants.SubCategory;

namespace WebStore.Web.ViewModels.SubCategory
{
    public class SubCategoryViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = "{0} must be between {2} and {1} characters long")]
        [Display(Name = "SubCategory Name")]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageURL { get; set; } = null!;
    }
}
