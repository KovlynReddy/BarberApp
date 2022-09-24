﻿using BarberAppDLL.Models.DomainModel;
using BarberAppDLL.Models.Dto;
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

        public BarberController()
        {
            _barberService = new BarberService();
        }
        // GET: BarberController
        public async Task<IActionResult> Index()
        {
            var allBarbers = await _barberService.GetAll(); 

            return View("ViewListBarbers",allBarbers);
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
        public async Task<IActionResult> Create(CreateBarberDto newbarber)
        {
            try
            {
              
                var result = await _barberService.Create(newbarber);
                return RedirectToAction(nameof(Index));
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