using Api.Car.Domain.Interfaces;
using Api.Car.Services;
using Autofac;

namespace Api.Car
{
    public class CarModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarService>()
                .As<ICarService>()
                .InstancePerLifetimeScope();
        }
    }
}
