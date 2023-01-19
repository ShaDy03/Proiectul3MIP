using Microsoft.AspNetCore.Mvc;

namespace Proiectul3MIP.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
