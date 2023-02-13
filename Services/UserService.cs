using POC_NET7.Models;
using POC_NET7.Repositories;

namespace POC_NET7.Services;

public class UserService
{
    // Dependency Injection
    public IDopaService _dopaService;
    public UserService(IDopaService dopaService) {
        _dopaService = dopaService;
    }
    public void InsertUser(User userReq)
    {
        UserRepository userRepository = new UserRepository();
        User user = new User();
        user.Firstname = userReq.Firstname;
        user.Lastname = userReq.Lastname;
        user.YearOfBirth = userReq.YearOfBirth;
        user.Age = new Util().CalculateAge(user.YearOfBirth);
        user.Phones = userReq.Phones;
        user.Address = _dopaService.getAddressByPostCode(10270);
        userRepository.InsertUser(user);
    }
}