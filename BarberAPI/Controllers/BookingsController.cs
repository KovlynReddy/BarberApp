using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BarberAPI.Data.DB;
using BarberAppDLL.Models.DomainModel;
using Microsoft.AspNetCore.Authorization;
using BarberAppDLL.Models.Dto;

namespace BarberAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingsController : Controller
    {
        private readonly BarberContext _context;

        public BookingsController(BarberContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bookings.ToListAsync());
        }

        [Route("~/api/Booking/GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var allBookings = await _context.Bookings.ToListAsync();
            List<BookingDto> allBookingDtos = new List<BookingDto>();

            foreach (var booking in allBookings)
            {
                allBookingDtos.Add( new BookingDto { 
                BookDateTimeString = booking.BookingTime,
                CreatedDateTimeString = booking.CreatedDateTime,
                ModelGuid = booking.ModelGUID,
                BarberGuid = booking.BarberGuid,
                UserGuid = booking.UserGuid
                });
            }

            return Ok(allBookingDtos);
        }


        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bookings/Create
        [AllowAnonymous]
        [Route("~/api/Booking/CreateDto")]
        [HttpPost]
        public async Task<IActionResult> CreateDto([FromBody] CreateBookingDto newBookingDto)
        {
            Booking newBooking = new Booking
            {
                Reason = newBookingDto.Reason,
                BookingTime = newBookingDto.BookDateTime.ToString(),
                ModelGUID = new Guid().ToString(),
                CreatedDateTime = DateTime.Now.ToString(),
                Rating = 0,
                Description = newBookingDto.Description,
                BarberGuid = newBookingDto.BarberGuid,
                UserGuid = newBookingDto.UserGuid,
                CreatorId = newBookingDto.UserGuid
            };
            _context.Add(newBooking);
            await _context.SaveChangesAsync();
            return Ok(newBooking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BarberGuid,UserGuid,Reason,Rating,Description,BookingTime,ArriveTime,CompletionTime,Id,ModelGUID,IsDeleted,CreatedDateTime,DeletedDateTime,CompletedDateTime,CreatorId")] Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id))
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
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
