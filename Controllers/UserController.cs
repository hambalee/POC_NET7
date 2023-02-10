using Microsoft.AspNetCore.Mvc;
using POC_NET7.Models;

namespace POC_NET7.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{

    [HttpGet()]
    public IActionResult GetUsers()
    {
        User user = new User();
        user.Firstname = "Lee";
        user.Lastname = "Hambalee";
        user.YearOfBirth = 1995;
        user.Age = DateTime.UtcNow.Year - user.YearOfBirth;
        return Ok(user);
    }
}