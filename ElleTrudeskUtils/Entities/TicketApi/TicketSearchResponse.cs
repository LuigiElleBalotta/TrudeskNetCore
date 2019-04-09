namespace ElleTrudeskUtils.Entities.TicketApi
{
    public class TicketSearchResponse
    {
        public bool success { get; set; }
        public string error { get; set; }
        public int count { get; set; }
        public Ticket[] tickets { get; set; }
    }
}
