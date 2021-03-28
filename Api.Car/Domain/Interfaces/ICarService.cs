using Api.Car.Domain.Entities;
using System;

namespace Api.Car.Domain.Interfaces
{
    public interface ICarService
    {
        CarDto GetById(Guid id);
    }
}
