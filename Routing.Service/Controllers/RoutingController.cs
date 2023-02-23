using Microsoft.AspNetCore.Mvc;

namespace Routing.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutingController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Task.FromResult(new
            {
                Id = Guid.NewGuid().ToString(),
                Source = "Bengaluru",
                Destination = "Chandausi",
            }));
        }
    }
}
