using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class FeedPost : BaseModel
    {
        public string SenderGuid { get; set; }
        public string RecieverGuid { get; set; }
        public string GroupGuid { get; set; }
        public string Message { get; set; }
    }
}
