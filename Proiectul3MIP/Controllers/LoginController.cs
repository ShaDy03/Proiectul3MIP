using DataAccess.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Text;

namespace Proiectul3MIP.Controllers
{
    public class LoginController : Controller
    {
        private readonly RegisterDatas _data;
        private readonly IUnitOfWorks _db;
        public LoginController(IUnitOfWorks db)
        {
            _db = db;
            var countries = db.Country.GetAll().ToList();
            var cities = db.City.GetAll().ToList();
            _data = new RegisterDatas(countries, cities);
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View(_data);
        }

        private string EncoderPassword(string password)
        {
            var asciiEncoder = ASCIIEncoding.ASCII.GetBytes(password);
            var encoderResult = Convert.ToBase64String(asciiEncoder);
            return encoderResult;
        }

        public IActionResult LoginNow(string email, string password)
        {
            var exist = _db.User.Exist(u => u.Email == email && u.Password == EncoderPassword(password));
            var id = _db.User.GetFirstOrDefault(u => u.Email == email && u.Password == EncoderPassword(password)).Id;
            if (exist)
                return RedirectToAction("Index", "Home", new { id = id });
            else
                return BadRequest("User not exists!");
        }

        public IActionResult RegisterNow([FromForm]User user)
        {
            if(!ModelState.IsValid && user.Password == user.ConfirmPassword)
            {
                return BadRequest(ModelState);
            }

            var address = new Address()
            {
                Street = user.Address.Street,
                Number = user.Address.Number,
                Apartament = user.Address.Apartament,
                Telephone = user.Address.Telephone,
                PostalCode= user.Address.PostalCode,
                CityID = user.Address.CityID,
                CountryID = user.Address.CountryID
            };

            _db.Address.Add(address);

            var newuser = new User()
            {
                Name= user.Name,
                SexID = user.SexID,
                Password = EncoderPassword(user.Password),
                AddressID = _db.Address.GetFirstOrDefault(a => a.Number == address.Number && a.CountryID == address.CountryID && a.Street == address.Street && a.PostalCode == address.PostalCode && a.Apartament == address.Apartament).Id,
                Email = user.Email
            };

            _db.User.Add(newuser);

            return RedirectToAction("Index", controllerName:"Login");
        }
    }
}
