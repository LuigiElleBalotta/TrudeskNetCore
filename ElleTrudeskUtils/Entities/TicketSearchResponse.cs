using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketSearchResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public int count { get; set; }
        public Ticket[] tickets { get; set; }
    }
}
