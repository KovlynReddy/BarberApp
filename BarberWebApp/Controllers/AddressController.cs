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
    public class AddressController : Controller
    {
        public AddressService _addressService { get; set; }
        public AddressController()
        {
            _addressService = new AddressService();
        }

        // GET: AddressController
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ViewMap()
        {
            MapViewModel model = new MapViewModel { 
            Lats = new List<string> {
            "-29.866807",
            "-29.966807",
            "-29.996807"
            },
            Longs = new List<string> {
            "30.884297",
            "30.784297",
            "30.684297"
            },
            Captions = new List<string> {
            "1",
            "2",
            "3"
            }, 
            Names = new List<string> {
            "a",
            "b",
            "c"
            },
            CenterLat = (-29.766807).ToString(), 
            CenterLon = (30.984297).ToString(), 
            Scale = 100.ToString() , 
            Zoom = 16.ToString()

            };

            

            return View("_MapView",model);
        }

        // GET: AddressController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddressController/Create
        public ActionResult Create()
        {
            CreateAddressViewModel model = new CreateAddressViewModel();

            return View(model);
        }

        // POST: AddressController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAddressViewModel newAddress)
        {
            try
            {
                CreateAddressDto newAddressDto = new CreateAddressDto {
                    Number = newAddress.Number,
                    Street = newAddress.Street,
                    MainStreet = newAddress.MainStreet,
                    Suburb = newAddress.Suburb,
                    Country = newAddress.Country,
                    PostCode = newAddress.PostCode,
                    ModelGuid = newAddress.ModelGuid,
                    CreatedDateTime = newAddress.CreatedDateTime,
                    Lat = newAddress.Lat,
                    lon = newAddress.lon,
                };

                var response = await _addressService.Create(newAddressDto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddressController/Edit/5
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

        // GET: AddressController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddressController/Delete/5
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
