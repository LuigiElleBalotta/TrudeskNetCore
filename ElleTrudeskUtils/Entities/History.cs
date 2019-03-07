using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class History
    {
        public string action { get; set; }
        public string description { get; set; }
        public Owner owner { get; set; }
        public string _id { get; set; }
        public DateTime date { get; set; }
    }
}
