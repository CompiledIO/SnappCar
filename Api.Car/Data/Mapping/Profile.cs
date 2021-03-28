using Api.Car.Domain.Entities;
using AutoMapper;

namespace Api.Car.Data.Mapping
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Entities.Car, CarDto>();
            CreateMap<CarDto, Entities.Car>();
        }
    }
}
