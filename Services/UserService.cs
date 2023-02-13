using POC_NET7.Models;
using POC_NET7.Repositories;

namespace POC_NET7.Services;

public class UserService
{

    public IDopaService _dopaService;
    public IUserRepository _userRepository;
    // Dependency Injection
    public UserService(IDopaService dopaService,IUserRepository userRepository) {
        _dopaService = dopaService;
        _userRepository = userRepository;
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
        _userRepository.InsertUser(user);
    }

    public List<User> GetUsers()
    {
        UserRepository userRepository = new UserRepository();
        return _userRepository.GetUsers();
    }
}