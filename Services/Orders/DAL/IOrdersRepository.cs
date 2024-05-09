using Orders.Models;

namespace Orders.DAL
{
    public interface IOrdersRepository
    {
        void SaveChanges();
        IQueryable<Order> GetAll();
        Order GetById(int id);
        void InsertOrUpdate(Order Orders);
        void Delete(Order Orders);
    }
}
