using Microsoft.EntityFrameworkCore;

namespace POC_NET7.Models;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Phone> Phones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=127.0.0.1;Database=UserPOC;User=root;Password=p@ssw0rd;", new MySqlServerVersion(new Version(8, 0, 31)));
    }
}