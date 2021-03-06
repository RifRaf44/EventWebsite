﻿using System;
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
        [HttpGet]
        public IActionResult Register()
        {
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Registration model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            using (var context = new RegistrationContext())
            {
                context.Registrations.Add(model);
                context.SaveChanges();
            }

            ViewBag.Message = "Your registration was succesful. You will be contacted soon.";
            ModelState.Clear();
            return View("Index");
        }

        // GET /stats
        [HttpGet("stats")]
        public IActionResult GetRegistrationStatistics()
        {
            using (var context = new RegistrationContext())
            {
                return new ObjectResult(new[] {
                    new { name= "ASP.NET 5", count=context.Registrations.Count(x=>x.Session1) },
                    new { name= "DevOps", count=context.Registrations.Count(x=>x.Session2) }
                });
            }
        }
    }
}
