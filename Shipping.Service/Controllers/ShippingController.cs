using Microsoft.AspNetCore.Mvc;

namespace Shipping.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Task.FromResult(new
            {
                Id = Guid.NewGuid().ToString(),
                IsShippingDone = true,
            }));
        }
    }
}
