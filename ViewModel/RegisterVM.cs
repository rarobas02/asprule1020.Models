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
    }
}
