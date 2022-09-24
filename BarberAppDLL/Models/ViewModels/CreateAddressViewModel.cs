﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.ViewModels
{
    public class CreateAddressViewModel
    {
        public string UserGuid { get; set; }
        public List<string> people { get; set; } = new List<string>();
        public int UserCode { get; set; } // either Barber or Customer
        public string Number { get; set; }
        public string Street { get; set; }
        public string MainStreet { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Lat { get; set; }
        public string lon { get; set; }
    }
}
