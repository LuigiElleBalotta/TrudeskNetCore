using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class Comment
    {
        public Owner owner { get; set; }
        public DateTime date { get; set; }
        public string comment { get; set; }
        public string _id { get; set; }
        public bool deleted { get; set; }
    }
}
