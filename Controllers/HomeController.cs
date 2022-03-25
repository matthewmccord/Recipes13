using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private IRecipesRepository _repo { get; set; }
        
        public HomeController(IRecipesRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var blah = _repo.Recipes
                .ToList();
            
            return View(blah);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
