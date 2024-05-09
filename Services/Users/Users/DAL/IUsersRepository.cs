using Users.Models;

namespace Users.DAL
{
    public interface IUsersRepository
    {
        void SaveChanges();
        IQueryable<User> GetAll();
        User GetById(int id);
        void InsertOrUpdate(User address);
        void Delete(User address);
    }
}
