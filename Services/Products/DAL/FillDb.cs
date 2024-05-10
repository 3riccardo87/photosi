using Products.Models;

namespace Products.DAL
{
    public static class FillDb
    {
        public static void Fill(IApplicationBuilder app)
        {
            using(var scope = app.ApplicationServices.CreateScope())
            {
                SeedData(scope.ServiceProvider.GetService<ProductsDbContext>());
            }
        }

        private static void SeedData(ProductsDbContext context) 
        {
            if (!context.Products.Any())
            {
                List<Product> list = new List<Product>()
                {
                    new Product()  {Name = "Pixel", Category = "Smartphone"},
                    new Product()  {Name = "iPhone", Category = "Smartphone"},
                    new Product()  {Name = "PS5", Category = "Console"},
                    new Product()  {Name = "Dell Latitude", Category = "Laptop"},
                };

                context.Products.AddRange(list);
                context.SaveChanges();
            }
        }
    }
}
