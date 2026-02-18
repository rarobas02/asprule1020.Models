using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asprule1020.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string EstUsername { get; set; }
        public string EstName { get; set; }
        public string? EstProvince { get; set; }

        public Guid? RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        [ValidateNever]
        public Register? Register { get; set; }
        [NotMapped]
        public string Role { get; set; }
    }
}
