using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class Api1Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("This is API 1");
}
