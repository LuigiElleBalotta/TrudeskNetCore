namespace ElleTrudeskUtils.Entities.UserApi
{
    public class Member
    {
        public string _id { get; set; }
        public string username { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public Preferences preferences { get; set; }
    }
}
