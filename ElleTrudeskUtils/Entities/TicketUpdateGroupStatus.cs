using System;
using System.Collections.Generic;
using System.Text;
using ElleTrudeskUtils.Entities.GroupApi;

namespace ElleTrudeskUtils.Entities
{
    public class TicketUpdateGroupStatus
    {
        public int status { get; set; }
        public Group group { get; set; }
        public string issue { get; set; }
        public string subject { get; set; }
    }
}
