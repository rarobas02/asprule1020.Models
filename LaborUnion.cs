using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asprule1020.Models
{
    public class LaborUnion
    {
        public Guid Id {  get; set; }
        public Guid? RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        [ValidateNever]
        public Register? Register { get; set; }
        public string? UnionName { get; set; }
        public string? UnionAddress { get; set; }
        public string? UnionBLR { get; set; }
    }
}
