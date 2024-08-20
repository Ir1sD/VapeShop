using Microsoft.AspNetCore.Mvc;
using System;

namespace VapeShop.Web.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Login()
		{
            return View("..\\Account\\Login");
        }

        public IActionResult Index()
        {
            return Ok();
        }
    }
}
