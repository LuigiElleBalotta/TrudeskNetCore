using System;
using System.Collections.Generic;
using System.Text;

namespace ElleTrudeskUtils.Entities
{
    public class UserInsertRequest
    {
        public string aUsername { get; set; }
        public string aPass { get; set; }
        public string aPassConfirm { get; set; }
        public string aFullname { get; set; }
        public string aEmail { get; set; }
        public string aRole { get; set; }
        public string aTitle { get; set; }
        public string[] aGrps { get; set; }
    }
}
