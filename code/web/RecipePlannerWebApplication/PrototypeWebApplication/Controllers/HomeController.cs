using Microsoft.AspNetCore.Mvc;
using PrototypeWebApplication.Models;
using System.Diagnostics;

namespace PrototypeWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<String> names = new List<String>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            NameDAL nameDAL = new NameDAL();
            this.names = nameDAL.getAllNames();
            ViewBag.names = this.names;
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