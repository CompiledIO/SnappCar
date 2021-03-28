using System;
using System.Collections.Generic;
using System.Linq;
using Api.Booking.Data.Interfaces;
using Api.Booking.Data.Requests;
using Api.Booking.Domain.Interfaces;
using Api.Booking.Domain.Requests;
using Api.Booking.Domain.Responses;
using Api.Car.Domain.Interfaces;
using AutoMapper;

namespace Api.Booking.Services
{
    public class BookingQuoteService : IBookingQuoteService
    {
        private readonly ICarService _carService;
        private readonly IBookingRepository _repository;
        private readonly IMapper _mapper;

        public BookingQuoteService(
            ICarService carService, 
            IBookingRepository repository,
            IMapper mapper)
        {
            _carService = carService;
            _repository = repository;
            _mapper = mapper;
        }

        public BookingQuoteResponse GenerateQuote(BookingQuoteRequest request)
        {
            var response = new BookingQuoteResponse
            {
                CarId = request.CarId,
                Price = 0
            };

            if (!_repository.CheckAvailability(_mapper.Map<BookingAvailabilityRequest>(request)).Available)
            {
                response.Message = "Deze auto zijn niet meer beschikbaar";
                return response;
            }

            response.Price = CalculatePrice(request);

            return response;
        }

        private decimal CalculatePrice(BookingQuoteRequest request)
        {
            var totalDays = (request.ToDateTime - request.FromDateTime).TotalDays;
            var car = _carService.GetById(request.CarId);

            if (car != null)
            {
                var basePrice = car.BasePrice;
                var calculatedPrice = basePrice * (decimal)totalDays;

                calculatedPrice += CalculateInsurance(basePrice, (decimal)totalDays);
                calculatedPrice += CalculateSnappCarProfit(basePrice, (decimal)totalDays);
                calculatedPrice += CalculateWeekendTariffs(request, basePrice);

                //Percentage
                if (totalDays > 3)
                {
                    calculatedPrice -= (calculatedPrice / 5) * 100;
                }

                return calculatedPrice;
            }

            return 0;
        }

        private decimal CalculateWeekendTariffs(BookingQuoteRequest request, decimal basePrice)
        {
            decimal weekendTariffs = 0;
            List<DateTime> dateRange = new List<DateTime>();
            for (DateTime dt = request.FromDateTime; dt < request.ToDateTime; dt = dt.AddDays(1))
            {
                dateRange.Add(dt);
            }

            var weekendDays = dateRange.Count(x => x.DayOfWeek == DayOfWeek.Saturday || x.DayOfWeek == DayOfWeek.Sunday);

            if (weekendDays > 0)
            {
                weekendTariffs = (basePrice / 5) * 100;
            }

            return weekendTariffs;
        }

        private decimal CalculateInsurance(decimal basePrice, decimal totalDays)
        {
            return ((basePrice * totalDays) / 10) * 100;
        }

        private decimal CalculateSnappCarProfit(decimal basePrice, decimal totalDays)
        {
            return ((basePrice * totalDays) / 10) * 100;
        }
    }
}
