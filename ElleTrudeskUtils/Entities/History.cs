using System;
using System.Collections.Generic;
using System.Text;
using ElleTrudeskUtils.Entities.UserApi;

namespace ElleTrudeskUtils.Entities
{
    public class History
    {
        public string action { get; set; }
        public string description { get; set; }
        public TrudeskUser owner { get; set; }
        public string _id { get; set; }
        public DateTime date { get; set; }
    }
}
