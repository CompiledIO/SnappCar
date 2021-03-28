using Api.Booking.Domain.Interfaces;
using Api.Booking.Domain.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Booking
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly IBookingQuoteService _bookingQuoteService;

        public BookingController(IBookingQuoteService bookingQuoteService)
        {
            _bookingQuoteService = bookingQuoteService;
        }

        [HttpGet]
        public IActionResult List([FromQuery]BookingQuoteRequest request)
        {
            return Ok(_bookingQuoteService.GenerateQuote(request));
        }
    }
}
