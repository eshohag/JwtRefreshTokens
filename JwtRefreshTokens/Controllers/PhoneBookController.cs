using JwtRefreshTokens.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtRefreshTokens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {
        // GET: api/PhoneBook
        [HttpGet]
        [Route("list")]
        [Authorize(Roles = "Admin")]
        public IActionResult List()
        {
            return Ok("Authorize, Phone Book List...");
        }
        [HttpGet]
        [Route("list1")]
        [Authorize(Roles = "User")]
        public IActionResult List1()
        {
            return Ok("List1, Phone Book List...");
        }
    }
}
