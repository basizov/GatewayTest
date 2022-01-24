using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TeaController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => Ok("Tea");
}
