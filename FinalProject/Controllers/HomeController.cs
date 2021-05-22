using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProject.Models;
using FinalProject.Data;
using FinalProject.BL;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StoresBL _storesBL;

        public HomeController(ILogger<HomeController> logger, BookStoreDbContext bookStoreDb)
        {
            _logger = logger;
            _storesBL = new StoresBL(bookStoreDb);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Store()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["stores"] = this._storesBL.GetAll();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
