using Microsoft.EntityFrameworkCore;
using POC_NET7.Models;

namespace POC_NET7.Repositories;

public class UserRepository : IUserRepository
{
    public void InsertUser(User user){
        UserDbContext dbContext = new UserDbContext();
        dbContext.Users.Add(user);
        dbContext.SaveChanges();
    }

    public List<User> GetUsers(){
        UserDbContext dbContext = new UserDbContext();
        List<User> users = dbContext.Users.Include(e => e.Phones).ToList();
        return users;
    }
}