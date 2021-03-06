﻿using System;
using System.Collections.Generic;
using System.Text;
using ElleTrudeskUtils.Entities.RolesApi;

namespace ElleTrudeskUtils.Entities
{
    public class TrudeskUser
    {
        public string _id { get; set; }
        public string username { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public TrudeskRole role { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public DateTime lastOnline { get; set; }
        public bool deleted { get; set; }
    }
}
