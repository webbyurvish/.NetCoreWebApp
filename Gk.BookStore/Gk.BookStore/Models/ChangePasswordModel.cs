﻿using System.ComponentModel.DataAnnotations;

namespace Gk.BookStore.Models
{
    public class ChangePasswordModel
    {
        [Required, DataType(DataType.Password) , Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "New Password")]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Confirm new Password")]
        [Compare("NewPassword" , ErrorMessage = "Confirm new password does not match")]
        public string ConfirmPassword { get; set;}
    }
}
