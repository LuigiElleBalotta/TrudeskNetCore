using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketCreateResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public TicketCreateRequest ticket { get; set; }
    }
}
