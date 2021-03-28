using System;

namespace Api.Car.Domain.Entities
{
    public class CarDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal BasePrice { get; set; }
    }
}
