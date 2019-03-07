using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class Group
    {
        public string _id { get; set; }
        public string name { get; set; }
        public bool Public { get; set; }
        public string[] sendMailTo { get; set; }
        public string[] members { get; set; }
    }
}
