using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session13Pro.Models;

namespace Session13Pro.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepositry studentRepositry;

        public HomeController(IStudentRepositry studentRepositry)
        {
            this.studentRepositry = studentRepositry;
        }
        public IActionResult Index()
        {
            return View(studentRepositry.GetAll());
        }

        public IActionResult Temp()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
