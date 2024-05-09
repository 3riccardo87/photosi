using Addresses.Models;

namespace Addresses.DAL
{
    public static class FillDb
    {
        public static void Fill(IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetService<AddressesDbContext>());
            }
        }

        private static void SeedData(AddressesDbContext context) 
        {
            if (!context.Addresses.Any())
            {
                List<Address> list = new List<Address>()
                {
                    new Address()  {Name = "Via Roma 6"},
                    new Address()  {Name = "Via Milano 2"},
                    new Address()  {Name = "Via Torino 10"}
                };

                context.Addresses.AddRange(list);
                context.SaveChanges();
            }
        }
    }
}
