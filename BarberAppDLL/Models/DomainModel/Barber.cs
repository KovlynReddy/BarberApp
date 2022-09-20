using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Barber : BaseModel
    {
        [Required]
        public string BarberName { get; set; }
        [Required]
        public string BarberEmail { get; set; }
        public string AddressGuid { get; set; }
        public string AverageRating { get; set; }
        public int Status { get; set; }
    }
}
