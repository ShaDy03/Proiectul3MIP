using Microsoft.AspNetCore.Mvc;

namespace Proiectul3MIP.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult History()
        {
            return History();
        }

       
    }
}
