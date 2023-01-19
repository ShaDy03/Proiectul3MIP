using DataAccess.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Proiectul3MIP.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWorks _db;

        public UserController(IUnitOfWorks db)
        {
            _db = db;
        }

        public IActionResult Profile(int id)
        {
            var profile = new User(); //TODO: Radu _db.User.GetById(id);
            return View(profile);
        }
    }
}
