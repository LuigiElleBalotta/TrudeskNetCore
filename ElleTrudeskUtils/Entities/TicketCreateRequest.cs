using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketCreateRequest
    {
        public string   subject { get; set; }
        public string   issue { get; set; }
        public string   owner { get; set; }
        public string   group { get; set; }
        public string   type { get; set; }
        public string   priority { get; set; }
        public string[] tags { get; set; }
    }
}
