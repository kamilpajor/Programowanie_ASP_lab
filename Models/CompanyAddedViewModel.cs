using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace NewBrandingStyle.Web.Models
{
    public class CompanyAddedViewModel
    {
        public int NumberOfCharsInName { get; set; }
        public int NumberOfCharsInDescryption { get; set; }
        public bool IsHidden { get; set; }
    }

}

