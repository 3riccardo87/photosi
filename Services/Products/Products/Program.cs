using Microsoft.EntityFrameworkCore;
using Products.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ProductsDbContext>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

FillDb.Fill(app);