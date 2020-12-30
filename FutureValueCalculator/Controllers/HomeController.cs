using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FutureValueCalculator.Models;

namespace FutureValueCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FutureValue = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel fv)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FutureValue = fv.Calculate().ToString("c2");
            }
            else
            {
                ViewBag.FutureValue = "";
            }

            return View();
            }

        public IActionResult Privacy()
        {
         
            return View();
        }
    }
}

