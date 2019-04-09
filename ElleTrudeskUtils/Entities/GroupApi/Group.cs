namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class Group
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string[] sendMailTo { get; set; }
        public string[] members { get; set; }
    }
}
