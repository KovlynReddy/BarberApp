using AutoMapper;
using BarberAppDLL.Models.DomainModel;
using BarberAppDLL.Models.Dto;
using BarberAppDLL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Helpers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            // barber
            CreateMap<Barber,BarberDto>();
            CreateMap<CreateBarberViewModel, CreateBarberDto>();
            CreateMap<CreateBarberDto, Barber>();

            // customer
            CreateMap<Customer, CustomerDto>();
            CreateMap<CreateCustomerViewModel, CreateCustomerDto>();
            CreateMap<CreateCustomerDto, Customer>();


            // booking
            CreateMap<Booking, BookingDto>();
            CreateMap<CreateBookingViewModel, CreateBookingDto>();
            CreateMap<CreateBookingDto, Booking>();


            // address
            CreateMap<Address, AddressDto>();
            CreateMap<CreateAddressViewModel, CreateAddressDto>();
            CreateMap<CreateAddressDto, Address>();


            // item
            //CreateMap<Item, ItemDto>();
            //CreateMap<CreateItemViewModel, CreateItemDto>();
            //CreateMap<CreateItemDto, Item>();

        }
    }
}
