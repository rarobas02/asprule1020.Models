using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace asprule1020.Models.ViewModel
{
    public class RegisterVM
    {
        public Register Register { get; set; } = new Register();

        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get => Register.password;
            set => Register.password = value;
        }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string confirmPassword { get; set; }
    }
}
