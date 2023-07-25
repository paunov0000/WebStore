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
        Task<List<CategoryViewModel>> ListAllCategoriesAsync();

        Task AddSaveAsync(CategoryViewModel model);

        Task<CategoryViewModel?> FindAsync(int id);

        Task SaveChangesAsync();
    }
}
