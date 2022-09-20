using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.Dto
{
    public class BookingDto
    {
        public string CreatedDateTime { get; set; }
        public string ArrivedDateTime { get; set; }
        public string BookDateTime { get; set; }
        public string CompletedDateTime { get; set; }
    }
}
