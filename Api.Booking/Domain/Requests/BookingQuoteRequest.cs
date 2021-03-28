using System;

namespace Api.Booking.Domain.Requests
{
    public class BookingQuoteRequest
    {
        public Guid CarId { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
    }
}
