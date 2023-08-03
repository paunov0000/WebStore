using AspNetCoreTemplate.Data.Models;
using System.ComponentModel.DataAnnotations;

using static WebStore.Common.EntityValidationConstants.Category;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }

        public string CategoryImageURL { get; set; } = null!;

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = "Category name must be between {2} and {1} characters long")]
        public string Name { get; set; } = null!;

        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
