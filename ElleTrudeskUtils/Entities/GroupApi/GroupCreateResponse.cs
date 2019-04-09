namespace ElleTrudeskUtils.Entities.GroupApi
{
    public class GroupCreateResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public Group group { get; set; }
    }
}
