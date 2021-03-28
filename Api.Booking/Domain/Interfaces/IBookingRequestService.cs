using Api.Booking.Domain.Requests;
using Api.Booking.Domain.Responses;

namespace Api.Booking.Domain.Interfaces
{
    public interface IBookingRequestService
    {
        BookingResponse PlaceBooking(BookingRequest request);
    }
}
