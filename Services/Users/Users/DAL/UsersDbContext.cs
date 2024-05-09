using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace Users.DAL
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
