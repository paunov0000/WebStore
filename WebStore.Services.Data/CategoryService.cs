using AspNetCoreTemplate.Web.ViewModels.Categories;
using WebStore.Data;
using WebStore.Services.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTemplate.Data.Models;

namespace WebStore.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly WebStoreDbContext dbContext;

        public CategoryService(WebStoreDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task CreateSaveAsync(CategoryViewModel model)
        {
            var category = new Category()
            {
                CategoryImageURL = model.CategoryImageURL,
                CreatedOn = DateTime.Now,
                Name = model.Name,
                IsDeleted = false,
                ModifiedOn = DateTime.Now
                //TODO: Do i have to map here the subcategories somehow???
            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
        }

        public async Task<CategoryViewModel?> FindAsync(Guid id)
            => await dbContext
                .Categories
                .Where(x => x.Id == id)
                .Select(x => new CategoryViewModel()
                {
                    CategoryImageURL = x.CategoryImageURL,
                    Name = x.Name,
                    Id = x.Id,
                })
                .FirstOrDefaultAsync(); //TODO: add a case when there isnt such category. the id isnt in the db
        

        public async Task<List<CategoryViewModel>> ListAllCategoriesAsync()
            => await dbContext
                    .Categories
                       .Where(x => x.IsDeleted == false)
                       .OrderBy(x => x.Name)
                    .Select(c => new CategoryViewModel()
                    {
                        CategoryImageURL = c.CategoryImageURL,
                        Id = c.Id,
                        Name = c.Name,
                        SubCategories = c.SubCategories.ToList()
                    })
                    .ToListAsync();

        public async Task SaveChangesAsync()
            => await dbContext.SaveChangesAsync();
    }
}
