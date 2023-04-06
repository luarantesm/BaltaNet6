using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [ApiKey]
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}