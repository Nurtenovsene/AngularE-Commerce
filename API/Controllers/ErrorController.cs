using API.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class ErrorController : BaseApiController
{
    [HttpGet]
    [Route("error/{code}")]
    public IActionResult Index(int code)
    {
        return new ObjectResult(code);
    }
}
