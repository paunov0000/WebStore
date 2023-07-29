using AspNetCoreTemplate.Web.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Services.Data.Interfaces
{
    public interface IAccountService
    {
        Task<IdentityResult> RegisterUserAsync(AccountRegisterViewModel model);

        Task<bool?> LoginUserAsync(string email, string password);

        Task LogoutUserAsync();
    }
}
