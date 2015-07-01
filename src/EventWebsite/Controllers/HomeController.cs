using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventWebsite.Migrations;
using EventWebsite.Models;
using Microsoft.AspNet.Mvc;

namespace EventWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            using(var context = new RegistrationContext())
            {
                if(!model.Session1 && !model.Session2)
                {
                    ViewBag.Message = "Please fill in at least one session";
                    return View(model);
                }
                else
                {
                    ViewBag.Message = "Your registration was succesful. You will be contacted soon.";
                    context.Users.Add(model);
                }
            }
            
            return View();
        }
    }
}
