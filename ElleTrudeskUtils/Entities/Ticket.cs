using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class Ticket
    {
        public DateTime date { get; set; }
        public bool deleted { get; set; }
        public int status { get; set; }
        public int uid { get; set; }
        public string _id { get; set; }
        public Tag[] tags { get; set; }
        public Comment[] comments { get; set; }
        public History[] history { get; set; }
        public Owner subscribers { get; set; }
        public DateTime updated { get; set; }
        public DateTime? closedDate { get; set; }
        public Group group { get; set; }
        public string issue { get; set; }
        public string subject { get; set; }
        public TrudeskType type { get; set; }
        public Owner owner { get; set; }
    }
}
