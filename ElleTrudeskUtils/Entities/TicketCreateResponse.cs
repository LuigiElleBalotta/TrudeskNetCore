using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketCreateResponse
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public TicketRequest Ticket { get; set; }
    }
}
