using Microsoft.AspNetCore.Mvc;
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
        private RecipesDbContext _context { get; set; }
        
        public HomeController(RecipesDbContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var blah = _context.Recipes.ToList();
            
            return View(blah);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
