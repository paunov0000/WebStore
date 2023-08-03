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

        public async Task CreateAsync(CategoryViewModel model) //TODO: change the name and remove the savechangesasync inside of the method
        {
            var category = new Category()
            {
                ImageURL = model.ImageURL,
                CreatedOn = DateTime.Now,
                Name = model.Name,
                IsDeleted = false,
                ModifiedOn = DateTime.Now
                //TODO: Do i have to map here the subcategories somehow???
            };

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var category = await FindCategoryAsync(id);

            if (category != null)
            {
                category.IsDeleted = true;
                await SaveChangesAsync();
            }
        }

        public async Task<CategoryViewModel?> FindAsync(Guid id) //TODO: make it w <> for the entity
            => await dbContext
                .Categories
                .Where(x => x.Id == id)
                .Select(x => new CategoryViewModel()
                {
                   ImageURL = x.ImageURL,
                    Name = x.Name,
                    Id = x.Id,
                })
                .FirstOrDefaultAsync(); //TODO: add a case when there isnt such category. the id isnt in the db

        public async Task<Category?> FindCategoryAsync(Guid id)
        => await dbContext
                .Categories
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync(); //TODO: what if its null? should return bad request or sum

        public async Task<List<CategoryViewModel>> ListAllAsync()
            => await dbContext
                    .Categories
                       .Where(x => x.IsDeleted == false)
                       .OrderBy(x => x.Name)
                    .Select(c => new CategoryViewModel()
                    {
                        ImageURL = c.ImageURL,
                        Id = c.Id,
                        Name = c.Name,
                        //SubCategories = c.SubCategories.ToList()
                    })
                    .ToListAsync();

        public async Task SaveChangesAsync()
            => await dbContext.SaveChangesAsync();
    }
}
