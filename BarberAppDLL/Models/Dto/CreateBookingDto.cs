using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.Dto
{
    public class CreateBookingDto : BaseDto
    {
        public DateTime BookingTime { get; set; }
    }
}
