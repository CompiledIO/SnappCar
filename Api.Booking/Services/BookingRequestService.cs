using Api.Booking.Data.Interfaces;
using Api.Booking.Domain.Interfaces;
using Api.Booking.Domain.Requests;
using Api.Booking.Domain.Responses;

namespace Api.Booking.Services
{
    public class BookingRequestService : IBookingRequestService
    {
        private readonly IBookingRepository _repository;

        public BookingRequestService(IBookingRepository repository)
        {
            _repository = repository;
        }

        public BookingResponse PlaceBooking(BookingRequest request)
        {
            return new BookingResponse();

            //Check if available - If available send to queue
            //_repository.CheckAvailability(request);
        }
    }
}
