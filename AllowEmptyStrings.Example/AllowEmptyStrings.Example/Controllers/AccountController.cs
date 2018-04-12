using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllowEmptyStrings.Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace AllowEmptyStrings.Example.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View();
        }
    }
}