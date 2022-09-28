using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtRefreshTokens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        // GET: api/healthCheck
        [HttpGet]
        [Route("status")]
        public IActionResult Status()
        {
            return Ok("Health is Good, Application is Running...");
        }
    }
}
