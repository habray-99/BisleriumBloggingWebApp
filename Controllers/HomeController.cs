using BisleriumBloggingWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BisleriumBloggingWebApp.Controllers
{
    public class HomeController : Controller
    {

        //creating constructor
        private readonly MyDbContext userDB;
        public HomeController(MyDbContext userDB)
        {
            this.userDB = userDB;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
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
