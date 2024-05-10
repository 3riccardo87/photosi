using Addresses.Models;

namespace Addresses.DAL
{
    public interface IAddressesRepository
    {
        void SaveChanges();
        IQueryable<Address> GetAll();
        Address GetById(int id);
        Address GetByName(string name);
        void InsertOrUpdate(Address address);
        void Delete(Address address);
    }
}
