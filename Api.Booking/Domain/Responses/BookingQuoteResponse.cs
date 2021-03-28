using System;

namespace Api.Booking.Domain.Responses
{
    public class BookingQuoteResponse
    {
        public Guid CarId { get; set; }
        public decimal Price { get; set; }
        public string Message { get; set; }
    }
}
