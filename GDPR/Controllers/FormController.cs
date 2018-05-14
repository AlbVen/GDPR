using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace MyLoanHomepage.Controllers
{
    public class FormsController : Controller
    {

		[HttpPost, ValidateAntiForgeryToken]
		[Route("Thankyou")]
		public IActionResult Thankyou(GDPR.Models.FormModel model)
			{
				ViewBag.Canonical = "/thankyou";
				return View("thankyou", model);

			}
		//public class SamlHolderModel
  //      {
  //          [Required]
  //          [Display(Name = "SAMLResponse")]
  //          public string SAMLResponse { get; set; }
  //      }
		
    }

}

