using POC_NET7.Models;

namespace POC_NET7.Repositories;

public interface IUserRepository
{
    public List<User> GetUsers();

    public void InsertUser(User userReq);
}