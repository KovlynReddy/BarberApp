﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.DomainModel
{
    public class BaseUser : BaseModel
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
    }
}
