using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities.RolesApi
{
    public class TrudeskRole
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string normalized { get; set; }
        public string[] grants{ get; set; }
        public bool hierarchy { get; set; }
    }
}
