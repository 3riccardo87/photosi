using Users.Models;

namespace Users.DAL
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersDbContext _context;
        public UsersRepository(UsersDbContext context)
        {
            _context = context;
        }
        public void Delete(User User)
        {
           _context.Remove(User);
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users.ToList().AsQueryable();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public void InsertOrUpdate(User User)
        {
            if (User.Id != 0)
            {
                _context.Add(User);
            }
            else
            {
                _context.Update(User);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
