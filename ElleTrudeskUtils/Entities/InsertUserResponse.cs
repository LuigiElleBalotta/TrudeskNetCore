using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class InsertUserResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public TrudeskUser account { get; set; }
    }
}
