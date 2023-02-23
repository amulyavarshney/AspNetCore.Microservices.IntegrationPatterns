using Microsoft.AspNetCore.Mvc;

namespace Delivery.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await Task.FromResult(new
            {
                Id = Guid.NewGuid().ToString(),
                DeliveryTime = DateTime.Now,
            }));
        }
    }
}
