using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Booking : BaseModel
    {
        public string BarberGuid { get; set; }
        public string UserGuid { get; set; }
        public string Reason { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public string BookingTime { get; set; }
        public string ArriveTime { get; set; }
        public string CompletionTime { get; set; }
    }
}
