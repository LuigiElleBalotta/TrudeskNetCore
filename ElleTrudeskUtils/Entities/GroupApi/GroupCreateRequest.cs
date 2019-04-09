namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class GroupCreateRequest
    {
        public string name { get; set; }
        public string[] members { get; set; }
        public string sendMailTo { get; set; }
    }
}
