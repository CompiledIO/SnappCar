using Api.Booking.Data.Interfaces;
using Api.Infrastructure.SQL.Context;
using Api.Infrastructure.SQL.Repositories;
using Autofac;

namespace Api.Infrastructure.SQL
{
    public class InfrastructureSqlModule : Module
    {
        private readonly string _connectionString;

        public InfrastructureSqlModule(string connectionString)
        {
            this._connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookingRepository>()
                .As<IBookingRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SqldbContext>()
                .WithParameter(new TypedParameter(typeof(string), this._connectionString));
        }
    }
}
