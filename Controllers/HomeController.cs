﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recipes13.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes13.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {      
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
