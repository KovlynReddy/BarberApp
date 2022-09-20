using BarberAPI.Data.DB;
using BarberWebApp.Models;
using BarberWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BarberWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //public BarberContext _Db { get; set; }

        public HomeController(ILogger<HomeController> logger)//,BarberContext Db)
        {
            _logger = logger;
           //_Db = Db;
        }

        public async Task<IActionResult> Index()
        {
            VisitService VS = new VisitService();
            var result = await VS.Get();
            
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
