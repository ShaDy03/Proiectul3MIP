﻿using DataAccess.Repository;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History(User user)
        {
            var profile = _db.History.GetAll(h => h.UserID  == user.Id);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}