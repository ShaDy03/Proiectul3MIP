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
            var profile = _db.User.GetById(id);
            profile.Address = _db.Address.GetById(profile.AddressID);
            profile.Address.Country = _db.Country.GetById(profile.Address.CountryID);
            profile.Address.City = _db.City.GetById(profile.Address.CityID);
            profile.SexType = _db.SexType.GetById(profile.SexID);
            return View(profile);
        }
    }
}
