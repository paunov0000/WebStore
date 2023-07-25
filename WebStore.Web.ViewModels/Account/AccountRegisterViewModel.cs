namespace AspNetCoreTemplate.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    using static WebStore.Common.EntityValidationConstants.User;

    public class AccountRegisterViewModel
    {
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; } = null!;

        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength)]
        public string Username { get; set; } = null!;

        // [PasswordPropertyText]
        [DataType(DataType.Password)] // Either this or the top one??
        public string Password { get; set; } = null!;
    }
}
