using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.Dto
{
    public class CreateCustomerDto : BaseDto
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }

    }
}
