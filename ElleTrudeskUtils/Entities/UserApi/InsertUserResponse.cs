namespace ElleTrudeskUtils.Entities.UserApi
{
    public class InsertUserResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public TrudeskUser account { get; set; }
    }
}
