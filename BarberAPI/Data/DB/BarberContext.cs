using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarberAppDLL.Models.DomainModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BarberAPI.Data.DB
{
    public class BarberContext : IdentityDbContext
    {

        public BarberContext(DbContextOptions<BarberContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Barber>().HasData(
                new Barber { Id = 1, BarberName = "Barber1", BarberEmail = "barber1@gmail.com", AddressGuid = "A1111", AverageRating = "10", Status = 0, CreatedDateTime = new DateTime().ToString(), CreatorId = "C1111", ModelGUID = "B1111", IsDeleted = 0 },
                new Barber { Id = 2, BarberName = "Barber2", BarberEmail = "barber2@gmail.com", AddressGuid = "A2222", AverageRating = "1", Status = 0, CreatedDateTime = new DateTime().ToString(), CreatorId = "C2222", ModelGUID = "B2222", IsDeleted = 0 }
                                                 );
            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, Number = "3", Street = "Street1", MainStreet = "Street10", Suburb = "Sub1", PostCode = "1111", Country = "USA", Lat = "1000", lon = "1111", CreatedDateTime = new DateTime().ToString(), ModelGUID = "A1111", CreatorId = "C1111", IsDeleted = 0 },
                new Address { Id = 2, Number = "6", Street = "Sreet2", MainStreet = "Street20", Suburb = "Sub2", PostCode = "2222", Country = "USB", Lat = "2000", lon = "2222", CreatedDateTime = new DateTime().ToString(), ModelGUID = "A2222", CreatorId = "C2222", IsDeleted = 0 }
                                                 );
            modelBuilder.Entity<LogVisit>().HasData(
                new LogVisit { Id = 1, BarberGuid = "B1111", UserGuid = "C1111", Reason = "Hair Cut", Rating = 2, Description = "Booking", BookingTime = new DateTime().ToString(), ArriveTime = new DateTime().ToString(), CompletionTime = new DateTime().ToString(), CreatedDateTime = new DateTime().ToString(), CompletedDateTime = new DateTime().ToString(), CreatorId = "C1111", ModelGUID = "V1111" },
                new LogVisit { Id = 2, BarberGuid = "B2222", UserGuid = "C2222", Reason = "Booking ", Rating = 2, Description = "Walk In", BookingTime = new DateTime().ToString(), ArriveTime = new DateTime().ToString(), CompletionTime = new DateTime().ToString(), CreatedDateTime = new DateTime().ToString(), CompletedDateTime = new DateTime().ToString(), CreatorId = "C2222", ModelGUID = "V2222" }
                                                 );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, CreatedDateTime = new DateTime().ToString(), CompletedDateTime = new DateTime().ToString(), CreatorId = "C1111", ModelGUID = "C1111", CustomerAddress = "A1111", CustomerEmail = "Customer1@gmail.com", CustomerName = "Customer1", Email = "Customer1@gmail.com", IsDeleted = 0, UserId = "1", UserName = "Customer1" },
                new Customer { Id = 2, CreatedDateTime = new DateTime().ToString(), CompletedDateTime = new DateTime().ToString(), CreatorId = "C2222", ModelGUID = "C2222", CustomerAddress = "A2222", CustomerEmail = "Customer2@gmail.com", CustomerName = "Customer2", Email = "Customer2@gmail.com", IsDeleted = 0, UserId = "2", UserName = "Customer2" }
                                                 );


            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // optionsBuilder.UseSqlServer("");
        //    base.OnConfiguring(optionsBuilder);
        //}

        public DbSet<Barber> Barbers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<LogVisit> LogVisits { get; set; }

     

    }
}
