using System.ComponentModel.DataAnnotations;

namespace CSC.IT.Store.ViewModels.Identity
{
    public class ChangePasswordViewModel
    {
        [Required, Display(Name = "Old Password"), DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required, Display(Name = "New Password"), DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required, Display(Name = "Confirm New Password"), DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
}
