using Api.Car.Domain.Entities;
using Api.Car.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Api.Car.Services
{
    public class CarService : ICarService
    {
        private List<Data.Entities.Car> _currentCarsInSystem;
        private readonly IMapper _mapper;

        public CarService(IMapper mapper)
        {
            _mapper = mapper;

            _currentCarsInSystem = new List<Data.Entities.Car>();

            _currentCarsInSystem.Add(new Data.Entities.Car
            {
                Id = Guid.Parse("0e974d16-0bd4-4570-a383-6ea505010699"),
                Name = "Atos",
                Type = "Hyundai",
                BasePrice = 25.50M
            });

            _currentCarsInSystem.Add(new Data.Entities.Car
            {
                Id = Guid.Parse("9d16d6f6-6ed6-4573-9a2d-b234ed512be6"),
                Name = "Model S",
                Type = "Tesla",
                BasePrice = 125.50M
            });
        }

        public CarDto GetById(Guid id)
        {
            return _mapper.Map<CarDto>(_currentCarsInSystem.FirstOrDefault(x => x.Id == id));
        }
    }
}
