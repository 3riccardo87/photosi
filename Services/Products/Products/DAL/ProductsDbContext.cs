using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.DAL
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
