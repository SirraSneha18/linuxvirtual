using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class Api2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("This is API 2");
}
