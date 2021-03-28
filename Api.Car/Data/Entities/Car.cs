using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Car.Data.Entities
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal BasePrice { get; set; }
    }
}
