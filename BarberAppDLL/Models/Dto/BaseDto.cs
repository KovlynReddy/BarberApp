using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.Dto
{
    public class BaseDto
    {
        public string CreatedDateTime { get; set; }
        public string ArrivedDateTime { get; set; }
        public string BookDateTime { get; set; }
        public string CompletedDateTime { get; set; }
        public int IsDeleted { get; set; }
        public string UserGuid { get; set; }
        public string BarberGuid { get; set; }
    }
}
