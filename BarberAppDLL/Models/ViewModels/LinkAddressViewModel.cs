using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace BarberAppDLL.Models.ViewModels
{
    public class LinkAddressViewModel
    {
        public List<SelectListItem> Addresses { get; set; } = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> People { get; set; } = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
        public string AddressGuid { get; set; }
        public string UserGuid { get; set; }
    }
}
