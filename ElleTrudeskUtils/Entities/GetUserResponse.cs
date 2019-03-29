using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class GetUserResponse
    {
        public bool success { get; set; }
        public string[] groups { get; set; }
        public TrudeskUser user { get; set; }
    }
}
