using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTemplate.Web.ViewModels.Account
{
    public class AccountLoginViewModel
    {
        [EmailAddress(ErrorMessage = "Email address is invalid.")]
        [Required]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; } = null!;
    }
}
