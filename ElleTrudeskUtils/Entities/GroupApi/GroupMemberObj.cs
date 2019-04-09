using System;
using System.Collections.Generic;
using System.Text;
using ElleTrudeskUtils.Entities.UserApi;

namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class GroupMemberObj
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string[] sendMailTo { get; set; }
        public Member[] members { get; set; }
    }
}
