using System;

namespace Api.Booking.Domain.Entities
{
    public class BookingDto
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid CarId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
