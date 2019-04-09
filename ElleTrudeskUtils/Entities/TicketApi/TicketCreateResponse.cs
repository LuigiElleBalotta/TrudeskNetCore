namespace ElleTrudeskUtils.Entities.TicketApi
{
    public class TicketCreateResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public TicketCreateRequest ticket { get; set; }
    }
}
