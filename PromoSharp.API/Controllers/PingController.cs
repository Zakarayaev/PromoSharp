using Microsoft.AspNetCore.Mvc;

namespace PromoSharp.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PingController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Pong");
    }
}