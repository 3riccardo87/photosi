using Products.Models;

namespace Products.DAL
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsDbContext _context;
        public ProductsRepository(ProductsDbContext context)
        {
            _context = context;
        }
        public void Delete(Product Product)
        {
           _context.Remove(Product);
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products.ToList().AsQueryable();
        }

        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public Product GetByName(string name)
        {
            return _context.Products.FirstOrDefault(p => p.Name == name);
        }

        public void InsertOrUpdate(Product Product)
        {
            if (Product.Id != 0)
            {
                _context.Add(Product);
            }
            else
            {
                _context.Update(Product);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
