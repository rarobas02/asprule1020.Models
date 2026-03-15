using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asprule1020.Models
{
    public class BranchUnit
    {
        public Guid Id { get; set; }
        public Guid? RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        [ValidateNever]
        public Register? Register { get; set; }
        public string? Rule1020Number { get; set; }
        public string? BranchName { get; set; }
        public string? BranchAddress { get; set; }

    }
}
