namespace AspNetCoreTemplate.Services.Data
{
    using AspNetCoreTemplate.Data.Models;
    using AspNetCoreTemplate.Web.ViewModels.Account;
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Threading.Tasks;
    using WebStore.Services.Data.Interfaces;

    public class AccountService : IAccountService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<SignInResult> LoginUserAsync(string email, string password)
        {
            var user = await this._userManager.FindByEmailAsync(email); // TODO: what if user is null?

            return await this._signInManager.PasswordSignInAsync(user, password, isPersistent: false, lockoutOnFailure: false); // TODO: check this

        }

        public async Task LogoutUserAsync()
        {
            await this._signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterUserAsync(AccountRegisterViewModel model) // TODO: Add claims n shit idk
        {
            var user = new ApplicationUser()
            {
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now,
                Email = model.EmailAddress,
                NormalizedEmail = model.EmailAddress.ToUpper(),
                UserName = model.Username,
                NormalizedUserName = model.Username.ToUpper(),
            };

            return  await this._userManager.CreateAsync(user, model.Password);
        }
    }
}
