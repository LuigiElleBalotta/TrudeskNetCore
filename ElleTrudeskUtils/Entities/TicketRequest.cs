using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketRequest
    {
        public string   subject { get; set; }
        public string   issue { get; set; }
        public int      owner { get; set; }
        public int      group { get; set; }
        public int      type { get; set; }
        public int      priority { get; set; }
    }
}
