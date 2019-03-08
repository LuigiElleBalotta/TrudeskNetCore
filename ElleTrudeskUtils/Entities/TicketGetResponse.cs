using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketGetResponse
    {
        public bool success { get; set; }
        public Ticket ticket { get; set; }
    }
}
