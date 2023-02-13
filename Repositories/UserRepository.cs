using POC_NET7.Models;

namespace POC_NET7.Repositories;

public class UserRepository
{
    public void InsertUser(User user){
        UserDbContext dbContext = new UserDbContext();
        dbContext.Users.Add(user);
        dbContext.SaveChanges();
    }
}