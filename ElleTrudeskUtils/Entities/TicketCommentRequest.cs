using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class TicketCommentRequest
    {
        public string comment { get; set; }
        public string ownerId { get; set; }
        public string _id { get; set; }
    }
}
