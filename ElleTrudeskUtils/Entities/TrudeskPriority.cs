using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TrudeskPriority
    {
        public int overDueIn { get; set; }
        public int migrationNum { get; set; }
        public string htmlColor { get; set; }
        public string _id { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string durationFormatted { get; set; }
    }
}
