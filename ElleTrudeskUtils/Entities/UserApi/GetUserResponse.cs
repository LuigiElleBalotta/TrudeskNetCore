namespace ElleTrudeskUtils.Entities.UserApi
{
    public class GetUserResponse
    {
        public bool success { get; set; }
        public string[] groups { get; set; }
        public TrudeskUser user { get; set; }
    }
}
