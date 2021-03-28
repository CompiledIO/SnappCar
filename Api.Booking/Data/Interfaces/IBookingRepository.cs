using Api.Booking.Data.Requests;
using Api.Booking.Data.Responses;

namespace Api.Booking.Data.Interfaces
{
    public interface IBookingRepository
    {
        BookingAvailabilityResponse CheckAvailability(BookingAvailabilityRequest request);
    }
}
