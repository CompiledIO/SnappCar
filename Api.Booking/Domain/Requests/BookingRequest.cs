using System;

namespace Api.Booking.Domain.Requests
{
    public class BookingRequest
    {
        public Guid CarId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
