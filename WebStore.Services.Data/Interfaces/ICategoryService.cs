using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> ListAllAsync();

        Task CreateAsync(CategoryViewModel model);

        Task<CategoryViewModel?> FindAsync(Guid id);

        Task<Category?> FindCategoryAsync(Guid id);

        Task SaveChangesAsync();

        Task DeleteAsync(Guid id);
    }
}
