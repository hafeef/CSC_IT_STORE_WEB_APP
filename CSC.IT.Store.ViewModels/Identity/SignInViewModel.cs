using System.ComponentModel.DataAnnotations;

namespace CSC.IT.Store.ViewModels.Identity
{
    public class SignInViewModel
    {
        [Required, Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required, Display(Name = "Password"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
