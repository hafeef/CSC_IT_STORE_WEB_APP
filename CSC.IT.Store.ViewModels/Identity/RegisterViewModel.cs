using CSC.Core.Common.Identity;
using System.ComponentModel.DataAnnotations;

namespace CSC.IT.Store.ViewModels.Identity
{
    public class RegisterViewModel
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required, Display(Name = "E-Mail"), EmailAddress]
        public string Email { get; set; }

        [Required, Range(1, 3, ErrorMessage = "The gender field is required.")]
        public Gender Gender { get; set; }

        [Required, Display(Name = "Password")]
        public string Password { get; set; }

        [Required, Display(Name = "Confirm Password"), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
