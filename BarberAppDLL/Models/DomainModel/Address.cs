using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class Address : BaseModel 
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string MainStreet { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public string Name { get; set; }
        public string Caption { get; set; }

        public string UserGuid { get; set; }

        public string Lat { get; set; }
        public string lon { get; set; }
    }
}
