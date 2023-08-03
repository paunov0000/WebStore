using AspNetCoreTemplate.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Services.Data.Interfaces;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Services.Data
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly WebStoreDbContext dbContext;

        public SubCategoryService(WebStoreDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task CreateAsync(SubCategoryViewModel model)
        {

            var subCategory = new SubCategory()
            {
                ImageURL = model.ImageURL,
                CreatedOn = DateTime.Now,
                Name = model.Name,
                IsDeleted = false,
                ModifiedOn = DateTime.Now
                //TODO: Do i have to map here the subcategories somehow???
            };

            await dbContext.SubCategories.AddAsync(subCategory);
            await dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryViewModel?> FindAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategoryViewModel?> FindSubCategoryAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SubCategoryViewModel>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
