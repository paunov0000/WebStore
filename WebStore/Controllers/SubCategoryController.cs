using AspNetCoreTemplate.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using WebStore.Services.Data;
using WebStore.Services.Data.Interfaces;
using WebStore.Web.ViewModels.SubCategory;

namespace WebStore.Web.Controllers
{
    public class SubcategoryController : Controller
    {
        private readonly ISubCategoryService subCategoryService;

        public SubcategoryController(ISubCategoryService _subCategoryService)
        {
            subCategoryService = _subCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var subcategories = await subCategoryService.ListAllAsync();

            return View(subcategories);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var subCategory = new SubCategoryViewModel()
            {
                Categories = await this.subCategoryService.GetCategories()
            };

            return this.View(subCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SubCategoryViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var categories = await this.subCategoryService.GetCategories();

            if (!categories.Any(b => b.Id == model.CategoryId))
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
            }

            await subCategoryService.CreateAsync(model);

            return this.RedirectToAction(nameof(this.Index));
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var subCategory = await subCategoryService.FindAsync(id);

            if (subCategory == null)
            {
                return BadRequest();
            }

            subCategory.Categories = await this.subCategoryService.GetCategories();


            return this.View(subCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SubCategoryViewModel model, Guid id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var subCategory = await subCategoryService.FindEntityAsync(id); //tf ??? just use the provided model

            if (subCategory != null)
            {
                subCategory.Name = model.Name;
                subCategory.ImageURL = model.ImageURL;
                subCategory.ModifiedOn = DateTime.Now;
                subCategory.CategoryId = model.CategoryId;
                await subCategoryService.SaveChangesAsync();
            }

            return this.RedirectToAction(nameof(this.Index));
        }

        public async Task<IActionResult> Delete(Guid id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction(nameof(this.Index));
            }

            await subCategoryService.DeleteAsync(id);

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
