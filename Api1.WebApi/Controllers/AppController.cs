using Microsoft.AspNetCore.Mvc;

namespace Api1.WebApi.Controllers;

[ApiController]
public class AppController : ControllerBase
{
    [HttpGet]
    [Route("app")]
    public IActionResult GetAppInfo()
    {
        return Ok(new { Version = "1.0.0-preview.3", Name = "Api1" });
    }
}
