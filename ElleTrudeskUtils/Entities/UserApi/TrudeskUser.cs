using System;
using ElleTrudeskUtils.Entities.RolesApi;

namespace ElleTrudeskUtils.Entities.UserApi
{
    public class TrudeskUser
    {
        public string _id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public TrudeskRole role { get; set; }
        public DateTime lastOnline { get; set; }
        public string title { get; set; }
        public string image { get; set; }

        public string resetPassHash { get; set; }
        public DateTime resetPassExpire { get; set; }
        public string tOTPKey { get; set; }
        public string tOTPPeriod { get; set; }
        public string resetL2AuthHash { get; set; }
        public DateTime resetL2AuthExpire { get; set; }
        public bool hasL2Auth { get; set; }
        public string accessToken { get; set; }
        public bool deleted { get; set; }
    }
}
