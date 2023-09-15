using Microsoft.EntityFrameworkCore;
using UserLoginProject.Models;

namespace UserLoginProject.Context
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
