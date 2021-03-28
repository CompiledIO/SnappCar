using Api.Booking.Domain.Interfaces;
using Api.Booking.Services;
using Autofac;

namespace Api.Booking
{
    public class BookingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookingQuoteService>()
                .As<IBookingQuoteService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookingRequestService>()
                .As<IBookingRequestService>()
                .InstancePerLifetimeScope();
        }
    }
}
