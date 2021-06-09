using App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("Movies")]
    public class MoviesController : Controller
    {
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
    }
}
