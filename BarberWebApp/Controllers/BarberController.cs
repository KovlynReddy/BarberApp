using BarberAppDLL.Models.DomainModel;
using BarberAppDLL.Models.Dto;
using BarberAppDLL.Models.ViewModels;
using BarberWebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberWebApp.Controllers
{
    public class BarberController : Controller
    {
        public BarberService _barberService { get; set; }
        public AddressService _addressService { get; set; }

        public BarberController()
        {
            _barberService = new BarberService();
            _addressService = new AddressService();
        }


        // GET: BarberController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allBarbers = await _barberService.GetAll(); 

            return View("ViewListBarbers",allBarbers);
        }

        [HttpGet]
        public async Task<IActionResult> ViewAll()
        {
            var allBarbers = await _barberService.GetAll();

            return View("ViewListBarbers", allBarbers);
        }

        // GET: BarberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BarberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BarberController/Create
        [HttpPost]
        public async Task<IActionResult> Create(CreateBarberViewModel newbarbervm)
        {
            try
            {
                CreateBarberDto newbarber = new CreateBarberDto
                {
                    BarberEmail = newbarbervm.BarberEmail,
                    BarberName = newbarbervm.BarberName
                };
              
                var result = await _barberService.Create(newbarber);
                return View("ViewBarber",newbarbervm);
            }
            catch
            {
                return View();
            }
        }

        // GET: BarberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Suggested() {
            // get all barbers
            var allBarbers = await _barberService.GetAll();

            // get all barbers addresses

            return View(allBarbers);
        }

        // POST: BarberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BarberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BarberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
