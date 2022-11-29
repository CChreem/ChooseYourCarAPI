using Application;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ReservationRequest request)
        {
            try
            {
                var carOperation = new CarOperation();

                var result = carOperation.Reservation(request);

                return Ok($"{result.Message} Seu número de ordem é: {result.OrderNumber}");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}