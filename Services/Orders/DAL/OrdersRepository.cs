using Orders.DAL;
using Orders.Models;

namespace Orders.DAL
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly OrdersDbContext _context;
        public OrdersRepository(OrdersDbContext context)
        {
            _context = context;
        }
        public void Delete(Order Order)
        {
           _context.Remove(Order);
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders.ToList().AsQueryable();
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(p => p.Id == id);
        }

        public void InsertOrUpdate(Order Order)
        {
            if (Order.Id != 0)
            {
                _context.Add(Order);
            }
            else
            {
                _context.Update(Order);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
