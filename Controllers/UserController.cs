using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_NET7.Models;
using POC_NET7.Services;

namespace POC_NET7.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    public IDopaService _dopaService;
    //Dependency Injection
    public UserController(IDopaService dopaService) {
        _dopaService = dopaService;
    }

    [HttpGet()]
    public IActionResult GetUsers()
    {
        UserService userService = new UserService(_dopaService);
        List<User> users = userService.GetUsers();
        return Ok(users);
    }

    [HttpPost()]
    public IActionResult InsertUser(User userReq)
    {
        UserService userService = new UserService(_dopaService);
        userService.InsertUser(userReq);
        return Ok();
    }
}