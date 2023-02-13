using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POC_NET7.Models;
using POC_NET7.Repositories;
using POC_NET7.Services;

namespace POC_NET7.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    public IDopaService _dopaService;
    public IUserRepository _userRepository;
    //Dependency Injection
    public UserController(IDopaService dopaService, IUserRepository userRepository)
    {
        _dopaService = dopaService;
        _userRepository = userRepository;

    }

    [HttpGet()]
    public IActionResult GetUsers()
    {
        UserService userService = new UserService(_dopaService,_userRepository);
        List<User> users = userService.GetUsers();
        return Ok(users);
    }

    [HttpPost()]
    public IActionResult InsertUser(User userReq)
    {
        UserService userService = new UserService(_dopaService,_userRepository);
        userService.InsertUser(userReq);
        return Ok();
    }
}