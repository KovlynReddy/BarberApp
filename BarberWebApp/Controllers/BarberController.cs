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
        public async Task<IActionResult> Suggested()
        {
           return View();
        }

       [HttpPost]
        public async Task<IActionResult> Suggested((int,int) location) {
            // get all barbers
            var allBarbers = await _barberService.GetAll();
            var allAddresses = await _addressService.GetAll();
            var allBarberAddresses = new List<Address>();
            var suggestedBarbers = new List<Address>();

            // get all barbers addresses

            foreach (var Barber in allBarbers)
            {
                allBarberAddresses.Add(allAddresses.FirstOrDefault(m=>m.CreatorId == Barber.ModelGUID));
            }

            MapViewModel model = new MapViewModel();

            // according to my location + - give as suggested
            foreach (var bAddress in allBarberAddresses)
            {
                if ((int.Parse(bAddress.Lat) - location.Item1).ToString().Length < 6 || (int.Parse(bAddress.lon) - location.Item2 ).ToString().Length < 6 )
                {
                    model.Lats.Add(bAddress.Lat);
                    model.Longs.Add(bAddress.lon);
                    model.Captions.Add(bAddress.Caption);
                    model.Names.Add(bAddress.Number + bAddress.Street);
                    suggestedBarbers.Add(bAddress);
                }
            }

            // display on a map centered at location
            model.CenterLat = (-29.766807).ToString();
            model.CenterLon = (30.984297).ToString();
            model.Scale = 100.ToString();
            model.Zoom = 16.ToString();

     

            return View("_MapView",model);
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
