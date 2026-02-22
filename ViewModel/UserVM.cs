using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace asprule1020.Models.ViewModel
{
    public class UserVM
    {
        public ApplicationUser? ApplicationUser { get; set; }
        public Guid Id { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }
        public string? SelectedRoleId { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? UserRoleList { get; set; }
    }
}
