using Products.Models;

namespace Products.DAL
{
    public interface IProductsRepository
    {
        void SaveChanges();
        IQueryable<Product> GetAll();
        Product GetById(int id);
        void InsertOrUpdate(Product Product);
        void Delete(Product Product);
    }
}
