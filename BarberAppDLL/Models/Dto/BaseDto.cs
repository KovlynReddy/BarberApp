using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.Dto
{
    public class BaseDto
    {
        public string CreatedDateTimeString { get; set; }
        public string ArrivedDateTimeString { get; set; }
        public string BookDateTimeString { get; set; }
        public string CompletedDateTimeString { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime ArrivedDateTime { get; set; }
        public DateTime BookDateTime { get; set; }
        public DateTime CompletedDateTime { get; set; } 
        public int IsDeleted { get; set; }
        public string ModelGuid { get; set; }
        public string CreatorGuid { get; set; }
        public string UserGuid { get; set; }
        public string BarberGuid { get; set; }
    }
}
