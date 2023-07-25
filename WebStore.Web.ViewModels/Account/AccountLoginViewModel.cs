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
        [EmailAddress]
        public string Email { get; set; } // TODO: implement later

        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
