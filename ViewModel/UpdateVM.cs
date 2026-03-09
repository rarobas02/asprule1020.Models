using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.Models.ViewModel
{
    public class UpdateVM
    {
        public Register Register { get; set; } = new Register();
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
