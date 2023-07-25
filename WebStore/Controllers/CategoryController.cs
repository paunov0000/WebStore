using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebStore.Services.Data.Interfaces;

namespace AspNetCoreTemplate.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await categoryService.ListAllCategoriesAsync();

            return this.View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var category = new CategoryViewModel();

            return this.View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            await categoryService.AddSaveAsync(model);

            return this.RedirectToAction(nameof(this.Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await categoryService.FindAsync(id);

            if (category == null) 
            {
                return BadRequest(); //TODO: idk if badrequest is a good return here lol
            }

            return this.View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel model, int id)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var category = await categoryService.FindAsync(id);

            if (category != null)
            {
                category.Name = model.Name;
                category.CategoryImageURL = model.CategoryImageURL;
                await categoryService.SaveChangesAsync();
            }

            return this.RedirectToAction(nameof(this.Index));
        }
    }
}
