using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class GroupGetSingleResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public GroupMemberObj group { get; set; }
    }
}
