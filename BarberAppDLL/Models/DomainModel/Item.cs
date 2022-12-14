using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Item : BaseModel
    {
        public string ItemName { get; set; }
        public string MenuId { get; set; }
        public string SKUCode { get; set; }
        public string Caption { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }
        public string Path { get; set; }
    }
}
