using Addresses.Models;
using Microsoft.EntityFrameworkCore;

namespace Addresses.DAL
{
    public class AddressesDbContext : DbContext
    {
        public AddressesDbContext(DbContextOptions<AddressesDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
    }
}
