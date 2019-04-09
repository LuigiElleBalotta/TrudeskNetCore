using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class GroupUpdateResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public Group group { get; set; }
    }
}
