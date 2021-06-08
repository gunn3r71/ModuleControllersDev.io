using App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("")]
    [Route("gestao")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("inicio/{id:int?}")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("termo")]
        public IActionResult Privacy(Movie movie)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("AOPA");
            }
            foreach (var value in ModelState.Values.SelectMany(e => e.Errors))
            {
                Console.WriteLine(value.ErrorMessage);
            }
            return View();
        }

        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
