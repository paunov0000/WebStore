using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Services.Data.Interfaces
{
    public interface ISubCategoryService
    {
        Task<List<SubCategoryViewModel>> ListAllAsync();

        Task CreateAsync(SubCategoryViewModel model);

        Task<SubCategoryViewModel?> FindAsync(Guid id);

        Task<SubCategory?> FindEntityAsync(Guid id);

        Task SaveChangesAsync();

        Task DeleteAsync(Guid id);

        Task<IEnumerable<CategoryViewModel>> GetCategories();

    }
}
