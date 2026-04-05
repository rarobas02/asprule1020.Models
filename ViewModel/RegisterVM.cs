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
        public IEnumerable<LaborUnion> LaborUnion { get; set; } = new List<LaborUnion>();
        public IEnumerable<BranchUnit> BranchUnit { get; set; } = new List<BranchUnit>();
        public  EvaluationChecklist CheckList{ get; set; } = new EvaluationChecklist();
        public EvaluationRemark Remarks { get; set; } = new EvaluationRemark();
    }
}
