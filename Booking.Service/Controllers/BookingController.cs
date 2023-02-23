using Microsoft.AspNetCore.Mvc;

namespace Booking.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Hello from Booking Service");
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Task.FromResult(new
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Amulya"
            }));
        }
    }
}
