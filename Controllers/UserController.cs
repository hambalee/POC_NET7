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
        UserDbContext dbContext = new UserDbContext();
        List<User> users = dbContext.Users.Include(e => e.Phones).ToList();
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