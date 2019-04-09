using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class GroupUpdateRequest
    {
        public string name { get; set; }
        public string[] members { get; set; }
        public string[] sendMailTo { get; set; }
    }
}
