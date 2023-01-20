using DataAccess.Repository;
using DataAccess.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;
using Proiectul3MIP.Models;
using System.Diagnostics;

namespace Proiectul3MIP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWorks _db;

        public HomeController(ILogger<HomeController> logger, IUnitOfWorks db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int id)
        {
            var user = _db.User.GetById(id);
            return View(user);
        }

        public IActionResult History(int id)
        {
            var profile = _db.History.GetAll(h => h.UserID  == id);
            return View(profile);
        }

        public IActionResult AddProdus(int id)
        {
            return View(id);
        }

        public IActionResult AddProdusNow(Produs produs, int userId)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                produs.BrandID = null!;
                produs.ImageID = null!;
                _db.Produs.Add(produs);
                return RedirectToAction("AddProdus", controllerName:"Home", new {id = userId});
            }
        }

        public IActionResult Order(int id, int userId)
        {
            var produs = _db.Produs.GetById(id);
            var history = new HistoryOrder()
            {
                OrderNumber = Guid.NewGuid().ToString(),
                Price = produs.Price,
                Quantity = 1,
                ProdusID = id,
                UserID = userId,
                Total = produs.Price
            };
            history.UnitId = _db.Unit.GetById(produs.UnitID).Id;
            _db.History.Add(history);
            return RedirectToAction("Shop", "Home");
        }

        public IActionResult Shop()
        {
            var produs = _db.Produs.GetAll(includes:x=>x.Unit);
            return View(produs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}