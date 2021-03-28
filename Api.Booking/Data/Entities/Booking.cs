using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Booking.Data.Entities
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid CarId { get; set; }
        [ForeignKey("CarId")]
        public Car.Data.Entities.Car Car { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
