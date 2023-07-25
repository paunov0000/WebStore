using AspNetCoreTemplate.Data.Models;

namespace AspNetCoreTemplate.Web.ViewModels.Categories
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string CategoryImageURL { get; set; } = null!;

        public string Name { get; set; }

        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
