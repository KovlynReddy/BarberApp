using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.ViewModels
{
    public class LinkAddressViewModel
    {
        public List<string> Addresses { get; set; }
        public List<string> People { get; set; }
        public string AddressGuid { get; set; }
        public string UserGuid { get; set; }
    }
}
