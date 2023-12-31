﻿using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Categories;
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
        private readonly WebStoreDbContext dbContext; //TODO: here must be a repository lol, code is repeating in every service lol

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
                ModifiedOn = DateTime.Now,
                CategoryId = model.CategoryId,
                //TODO: Do i have to map here the subcategories somehow???
            };

            await dbContext.SubCategories.AddAsync(subCategory);
            await dbContext.SaveChangesAsync(); //TODO: make use of the savechangesasync method in the service!!!
        }

        public async Task DeleteAsync(Guid id)
        {
            var subCategory = await FindEntityAsync(id);

            if (subCategory != null)
            {
                subCategory.IsDeleted = true;
                await SaveChangesAsync();
            }
        }

        public async Task<SubCategoryViewModel?> FindAsync(Guid id) //TODO: make it w <> for the entity
            => await dbContext
                .SubCategories
                .Where(x => x.Id == id)
                .Select(x => new SubCategoryViewModel()
                {
                    ImageURL = x.ImageURL,
                    Name = x.Name,
                    Id = x.Id,
                })
                .FirstOrDefaultAsync(); //TODO: add a case when there isnt such category. the id isnt in the db


        public async Task<SubCategory?> FindEntityAsync(Guid id)
        => await dbContext
                .SubCategories
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync(); //TODO: what if its null? should return bad request or sum

        public async Task<IEnumerable<CategoryViewModel>> GetCategories()
            => await dbContext.Categories
            .Where(c=> c.IsDeleted == false)
            .Select(c => new CategoryViewModel()
            {
                Id = c.Id,
                ImageURL = c.ImageURL,
                Name = c.Name,
            })
            .ToListAsync();

        public async Task<List<SubCategoryViewModel>> ListAllAsync()
            => await dbContext
                    .SubCategories
                       .Where(x => x.IsDeleted == false)
                       .OrderBy(x => x.Name)
                    .Select(sc => new SubCategoryViewModel()
                    {
                        ImageURL = sc.ImageURL,
                        Id = sc.Id,
                        Name = sc.Name,
                        CategoryName = sc.Category.Name
                        //SubCategories = c.SubCategories.ToList()
                    })
                    .ToListAsync();

        public async Task SaveChangesAsync()
            => await dbContext.SaveChangesAsync();
    }
}
