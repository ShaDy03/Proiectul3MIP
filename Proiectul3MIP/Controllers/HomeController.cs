using DataAccess.Repository;
using DataAccess.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Enum;
using Proiectul3MIP.Models;
using System.Diagnostics;

namespace Proiectul3MIP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWorks _db;

        public HomeController(ILogger<HomeController> logger, UnitOfWorks db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
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