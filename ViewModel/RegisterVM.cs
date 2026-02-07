using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.Models.ViewModel
{
    public class RegisterVM
    {
        public Register? Register { get; set; }
        public IEnumerable<SelectListItem>? RegionList { get; set; }
    }
}
