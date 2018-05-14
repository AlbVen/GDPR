﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GDPR.Pages
{
    public class ThankyouModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Thank you.";
        }
    }
}
