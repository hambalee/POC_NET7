using Microsoft.AspNetCore.Mvc;
using POC_NET7.Models;
using POC_NET7.Services;

namespace POC_NET7.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{

    [HttpGet()]
    public IActionResult GetUsers()
    {
        UserDbContext dbContext = new UserDbContext();
        List<User> users = dbContext.Users.ToList();
        return Ok(users);
    }

    [HttpPost()]
    public IActionResult InsertUser(User userReq)
    {
        UserDbContext dbContext = new UserDbContext();
        User user = new User();
        user.Firstname = userReq.Firstname;
        user.Lastname = userReq.Lastname;
        user.YearOfBirth = userReq.YearOfBirth;
        user.Age = new Util().CalculateAge(user.YearOfBirth);
        dbContext.Users.Add(user);
        dbContext.SaveChanges();
        return Ok(user);
    }
}