using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Item : BaseModel
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
    }
}
