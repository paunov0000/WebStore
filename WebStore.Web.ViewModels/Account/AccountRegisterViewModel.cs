namespace AspNetCoreTemplate.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    using static WebStore.Common.EntityValidationConstants.User;

    public class AccountRegisterViewModel
    {
        [EmailAddress(ErrorMessage = "Email address is invalid")]
        [Display(Name = "Email address")]
        [Required]
        public string EmailAddress { get; set; } = null!;

        [Required]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength, ErrorMessage = "The {0} must be at least {2} characters long and not more than {1} characters")]
        [RegularExpression(@"^[a-zA-z0-9]*$", ErrorMessage = "Usernames must be alphanumeric only.")]
        public string Username { get; set; } = null!;

		// [PasswordPropertyText]
		[Required]
		[DataType(DataType.Password)] // Either this or the top one??
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare(nameof(Password), ErrorMessage = "Passwords must match.")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
