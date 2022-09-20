using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Deal : BaseModel
    {
        [Required]
        public string BarberGuid { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Reason { get; set; }
        public int Percentage { get; set; }
        public int Amount { get; set; }
    }
}
