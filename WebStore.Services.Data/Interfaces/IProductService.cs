using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using WebStore.Web.ViewModels.Product;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Services.Data.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> ListAllAsync();

        Task CreateAsync(ProductViewModel model);

        Task<ProductViewModel?> FindAsync(Guid id);

        Task<Product?> FindEntityAsync(Guid id);

        Task SaveChangesAsync();

        Task DeleteAsync(Guid id);

        Task<IEnumerable<SubCategoryViewModel>> GetSubCategories();

        //public Guid GetUserId();
    }
}
