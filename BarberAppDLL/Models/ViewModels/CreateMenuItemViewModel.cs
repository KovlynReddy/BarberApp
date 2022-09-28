using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.ViewModels
{
    public class CreateMenuItemViewModel 
    {
        public string ItemName { get; set; }
        public string MenuId { get; set; }
        public string SKUCode { get; set; }
        public string Caption { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }
        public string CreatedDateTime { get; set; }
        public string CreatorId { get; set; }
        //public IFormFile ItemImage { get; set; }
    }
}
