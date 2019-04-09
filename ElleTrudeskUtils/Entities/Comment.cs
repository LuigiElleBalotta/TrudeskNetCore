using System;
using System.Collections.Generic;
using System.Text;
using ElleTrudeskUtils.Entities.UserApi;

namespace ElleTrudeskUtils.Entities
{
    public class Comment
    {
        public TrudeskUser owner { get; set; }
        public DateTime date { get; set; }
        public string comment { get; set; }
        public string _id { get; set; }
        public bool deleted { get; set; }
    }
}
