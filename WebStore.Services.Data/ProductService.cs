using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using Microsoft.EntityFrameworkCore;
using WebStore.Data;
using WebStore.Services.Data.Interfaces;
using WebStore.Web.ViewModels.Product;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Services.Data
{
    public class ProductService : IProductService
    {
        private readonly WebStoreDbContext dbContext; //TODO: here must be a repository lol, code is repeating in every service lol

        public ProductService(WebStoreDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task CreateAsync(ProductViewModel model)
        {

            var product = new Product()
            {
                ImageURL = model.ImageURL,
                CreatedOn = DateTime.Now,
                Name = model.Name,
                IsDeleted = false,
                ModifiedOn = DateTime.Now,
                SubCategoryId = model.SubCategoryId,
                ApplicationUserId = model.ApplicationUserId,
                Description = model.Description,
                IsOnSale = false,
                //CategoryId = model.CategoryId,
                //TODO: Do i have to map here the subcategories somehow???
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync(); //TODO: make use of the savechangesasync method in the service!!!
        }

        public async Task DeleteAsync(Guid id)
        {
            var product = await FindEntityAsync(id);

            if (product != null)
            {
                product.IsDeleted = true;
                await SaveChangesAsync();
            }
        }

        //public Guid GetUserId()
        //        => User.FindFirstValue(ClaimTypes.NameIdentifier);

        public async Task<ProductViewModel?> FindAsync(Guid id) //TODO: make it w <> for the entity
            => await dbContext
                .Products
                .Where(x => x.Id == id)
                .Select(x => new ProductViewModel()
                {
                    ImageURL = x.ImageURL,
                    Name = x.Name,
                    Id = x.Id,
                    Description = x.Description,
                    ApplicationUserId = x.ApplicationUserId,
                })
                .FirstOrDefaultAsync(); //TODO: add a case when there isnt such category. the id isnt in the db


        public async Task<Product?> FindEntityAsync(Guid id)
        => await dbContext
                .Products
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync(); //TODO: what if its null? should return bad request or sum

        public async Task<IEnumerable<SubCategoryViewModel>> GetSubCategories()
            => await dbContext.SubCategories
            .Where(sc => sc.IsDeleted == false)
            .Select(sc => new SubCategoryViewModel()
            {
                Id = sc.Id,
                Name = sc.Name,
            })
            .ToListAsync();

        public async Task<List<ProductViewModel>> ListAllAsync()
            => await dbContext
                    .Products
                       .Where(x => x.IsDeleted == false)
                       .OrderBy(x => x.Name)
                    .Select(p => new ProductViewModel()
                    {
                        ImageURL = p.ImageURL,
                        Id = p.Id,
                        Name = p.Name,
                        //CategoryName = p.Category.Name
                        //SubCategories = c.SubCategories.ToList()
                    })
                    .ToListAsync();

        public async Task SaveChangesAsync()
            => await dbContext.SaveChangesAsync();
    }
}

