using Api.Booking.Data.Interfaces;
using Api.Booking.Data.Requests;
using Api.Booking.Data.Responses;
using Api.Infrastructure.SQL.Context;
using System.Linq;

namespace Api.Infrastructure.SQL.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly SqldbContext _context;

        public BookingRepository(SqldbContext context)
        {
            _context = context;
        }

        public BookingAvailabilityResponse CheckAvailability(BookingAvailabilityRequest request)
        {
            var hasBooking = _context.Bookings.Any(x => x.CarId == request.CarId
                                                && x.ToDate <= request.ToDateTime
                                                && x.FromDate >= request.FromDateTime);

            return new BookingAvailabilityResponse
            {
                Available = !hasBooking
            };

        }
    }
}
