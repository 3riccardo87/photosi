using Microsoft.EntityFrameworkCore;
using Orders.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<OrdersDbContext>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();