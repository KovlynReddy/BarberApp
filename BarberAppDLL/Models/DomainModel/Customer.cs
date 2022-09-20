using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Customer : BaseUser 
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
    }
}
