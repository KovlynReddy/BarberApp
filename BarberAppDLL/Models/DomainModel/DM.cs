using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class DM : BaseModel
    {
        public string SenderGuid { get; set; }
        public string RecieverGuid { get; set; }
        public string GroupGuid { get; set; }
        public string Message { get; set; }
        public string AttatchmentString { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public int Read { get; set; }

    }
}
