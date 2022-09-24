using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarberAPI.Data.DB;
using BarberAppDLL.Models.DomainModel;
using System.Net.Http;
using BarberAppDLL.Models.Dto;
using Microsoft.AspNetCore.Authorization;

namespace BarberAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BarbersController : Controller
    {
        private readonly BarberContext _context;

        public BarbersController(BarberContext context)
        {
            _context = context;
        }

        // GET: Barbers
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Barber> barbers = new List<Barber>();
            barbers.Add(new Barber { Id = 1, BarberName = "Barber1", BarberEmail = "barber1@gmail.com", AddressGuid = "A1111", AverageRating = "10", Status = 0, CreatedDateTime = new DateTime().ToString(), CreatorId = "C1111", ModelGUID = "B1111", IsDeleted = 0 });
            barbers.Add(new Barber { Id = 2, BarberName = "Barber2", BarberEmail = "barber2@gmail.com", AddressGuid = "A2222", AverageRating = "1", Status = 0, CreatedDateTime = new DateTime().ToString(), CreatorId = "C2222", ModelGUID = "B2222", IsDeleted = 0 });

            //_context.Barbers.AddRange(barbers);
            //_context.SaveChanges();

            var result = await _context.Barbers.ToListAsync();
            result.AddRange(barbers);

            HttpResponseMessage response = new HttpResponseMessage();
            response.StatusCode = System.Net.HttpStatusCode.OK;
            //response.Content = result;

            return Ok(result);
        }

        // GET: Barbers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barber = await _context.Barbers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (barber == null)
            {
                return NotFound();
            }

            return View(barber);
        }


        // POST: Barbers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [AllowAnonymous]
        [Route("~/api/Barbers/Create")]
        [Route("~/api/Barbers/Create/{BarberEmail}/{BarberName}")]
        //[Route("api/Barbers/Create?BarberEmail={BarberEmail}&BarberName={BarberName}")]
        [HttpPost]
        public async Task<IActionResult> Create( string BarberEmail,string BarberName)//[FromBody]CreateBarberDto barber)
        {
            Barber newBarber = new Barber
            {
                BarberEmail = BarberEmail,//barber.BarberEmail,//
                BarberName = BarberName,//barber.BarberName,//
                ModelGUID = new Guid().ToString(),
                CreatedDateTime = new DateTime().ToString()
            };
                _context.Add(newBarber);
                await _context.SaveChangesAsync();
                return Ok(newBarber);
        }

        [HttpGet]
        [Route("~/api/Barbers/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _context.Barbers.ToListAsync();

            return Ok(result);
        }

            [AllowAnonymous]
        [Route("~/api/Barbers/CreateDto")]
        [Route("~/api/Barbers/CreateDto/{BarberEmail}/{BarberName}")]
        //[Route("api/Barbers/Create?BarberEmail={BarberEmail}&BarberName={BarberName}")]
        [HttpPost]
        public async Task<IActionResult> CreateDto([FromBody]CreateBarberDto barber)
        {
            Barber newBarber = new Barber
            {
                BarberEmail = barber.BarberEmail,//
                BarberName = barber.BarberName,//
                ModelGUID = new Guid().ToString(),
                CreatedDateTime = new DateTime().ToString()
            };
            _context.Add(newBarber);
            await _context.SaveChangesAsync();
            return Ok(newBarber);
        }

        // GET: Barbers/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barber = await _context.Barbers.FindAsync(id);
            if (barber == null)
            {
                return NotFound();
            }
            return View(barber);
        }

        // POST: Barbers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpGet]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BarberName,AddressGuid,AverageRating,Status,Id,ModelGUID,IsDeleted,CreatedDateTime,DeletedDateTime,CompletedDateTime,CreatorId")] Barber barber)
        {
            if (id != barber.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(barber);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BarberExists(barber.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(barber);
        }

        // GET: Barbers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var barber = await _context.Barbers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (barber == null)
            {
                return NotFound();
            }

            return View(barber);
        }

        // POST: Barbers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var barber = await _context.Barbers.FindAsync(id);
            _context.Barbers.Remove(barber);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BarberExists(int id)
        {
            return _context.Barbers.Any(e => e.Id == id);
        }
    }
}
