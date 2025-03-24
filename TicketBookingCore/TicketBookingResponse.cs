namespace TicketBookingCore
{
    public class TicketBookingResponse : TicketBookingBase
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}