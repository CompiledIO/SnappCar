using Api.Booking.Data.Requests;
using Api.Booking.Domain.Entities;
using Api.Booking.Domain.Requests;
using AutoMapper;

namespace Api.Booking.Data.Mapping
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Entities.Booking, BookingDto>();
            CreateMap<BookingDto, Entities.Booking>();

            CreateMap<BookingQuoteRequest, BookingAvailabilityRequest>();
        }
    }
}
