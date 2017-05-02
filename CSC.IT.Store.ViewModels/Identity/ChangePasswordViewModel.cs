using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC.IT.Store.ViewModels.Identity
{
    public class ChangePasswordViewModel
    {
        [Required, Display(Name ="Old Password"), DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Required, Display(Name = "New Password"), DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required, Display(Name = "Confirm New Password"), DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
}
