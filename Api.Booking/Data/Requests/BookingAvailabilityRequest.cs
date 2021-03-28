using System;

namespace Api.Booking.Data.Requests
{
    public class BookingAvailabilityRequest
    {
        public Guid CarId { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
    }
}
