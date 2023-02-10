using Microsoft.AspNetCore.Mvc;

namespace POC_NET7.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase {

    [HttpGet()]
    public IActionResult GetUsers() {
        return Ok(new { FirstName = "Lee"});
    }
}