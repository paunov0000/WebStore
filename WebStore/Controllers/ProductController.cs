using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebStore.Services.Data;
using WebStore.Services.Data.Interfaces;
using WebStore.Web.ViewModels.Product;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await productService.ListAllAsync();

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var product = new ProductViewModel()
            {
                //ApplicationUserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)) //TODO: will it parse it as guid?
                SubCategories = await this.productService.GetSubCategories(),
                IsDeleted = false,

            };

            return this.View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            var subCategories = await this.productService.GetSubCategories();

            if (!this.ModelState.IsValid)
            {
                model.SubCategories = subCategories;
                return this.View(model);
            }

            if (!subCategories.Any(sc => sc.Id == model.SubCategoryId))
            {
                ModelState.AddModelError(nameof(model.SubCategoryId), "Subcategory does not exist");
            }

            var currUserId = GetUserId();

            model.ApplicationUserId = currUserId;


            await productService.CreateAsync(model);

            return this.RedirectToAction(nameof(this.Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var product = await productService.FindAsync(id);

            if (product == null)
            {
                return BadRequest();
            }

            var currUserId = GetUserId();

            if (currUserId != product.ApplicationUserId)
            {
                return Unauthorized();
            }


            product.SubCategories = await this.productService.GetSubCategories();


            return this.View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductViewModel model, Guid id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var product = await productService.FindEntityAsync(id); //tf ??? just use the provided model

            if (product != null)
            {
                product.Name = model.Name;
                product.ImageURL = model.ImageURL;
                product.ModifiedOn = DateTime.Now;
                product.SubCategoryId = model.SubCategoryId;
                product.Description = model.Description;
                await productService.SaveChangesAsync();
            }

            return this.RedirectToAction(nameof(this.Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction(nameof(this.Index));
            }

            await productService.DeleteAsync(id);

            return this.RedirectToAction(nameof(this.Index));
        }


        private Guid GetUserId()
            => Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}
