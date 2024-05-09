using Users.Models;

namespace Users.DAL
{
    public static class FillDb
    {
        public static void Fill(IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetService<UsersDbContext>());
            }
        }

        private static void SeedData(UsersDbContext context) 
        {
            if (!context.Users.Any())
            {
                List<User> list = new List<User>()
                {
                    new User()  {Username = "MarioRossi"},
                    new User()  {Username = "FabioBianchi"},
                    new User()  {Username = "PaoloVerdi"},
                };

                context.Users.AddRange(list);
                context.SaveChanges();
            }
        }
    }
}
