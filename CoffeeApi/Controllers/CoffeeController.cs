using Microsoft.AspNetCore.Mvc;

namespace CoffeeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoffeeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => Ok("Coffee");
}
