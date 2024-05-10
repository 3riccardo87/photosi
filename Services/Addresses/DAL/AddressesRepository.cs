using Addresses.Models;

namespace Addresses.DAL
{
    public class AddressesRepository : IAddressesRepository
    {
        private readonly AddressesDbContext _context;
        public AddressesRepository(AddressesDbContext context)
        {
            _context = context;
        }
        public void Delete(Address address)
        {
           _context.Remove(address);
        }

        public IQueryable<Address> GetAll()
        {
            return _context.Addresses.ToList().AsQueryable();
        }

        public Address GetById(int id)
        {
            return _context.Addresses.FirstOrDefault(p => p.Id == id);
        }

        public Address GetByName(string name)
        {
            return _context.Addresses.FirstOrDefault(p => p.Name == name);
        }

        public void InsertOrUpdate(Address address)
        {
            if (address.Id != 0)
            {
                _context.Add(address);
            }
            else
            {
                _context.Update(address);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
