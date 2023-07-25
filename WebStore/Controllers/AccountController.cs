using Microsoft.AspNetCore.Mvc;
using AspNetCoreTemplate.Data.Models;
using AspNetCoreTemplate.Web.ViewModels.Account;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebStore.Services.Data.Interfaces;

namespace AspNetCoreTemplate.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            this._accountService = accountService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            var model = new AccountRegisterViewModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var result = await this._accountService.RegisterUserAsync(model);

            if (result.Succeeded)
            {
                await this._accountService.LoginUserAsync(model.EmailAddress, model.Password);
                return this.RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                this.ModelState.AddModelError(string.Empty, error.Description);
            }

            return this.View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new AccountLoginViewModel();

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var result = await this._accountService.LoginUserAsync(model.Email, model.Password);

            if (result.Succeeded)
            {
                return this.RedirectToAction("Index", "Home");
            }

            this.ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await this._accountService.LogoutUserAsync();
            if (returnUrl != null)
            {
                return this.LocalRedirect(returnUrl);
            }

            return this.RedirectToAction("Index", "Home");
        }
    }
}
