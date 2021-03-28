using Api.Booking.Domain.Requests;
using Api.Booking.Domain.Responses;

namespace Api.Booking.Domain.Interfaces
{
    public interface IBookingQuoteService
    {
        BookingQuoteResponse GenerateQuote(BookingQuoteRequest request);
    }
}
