using Addresses.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(); 
builder.Services.AddDbContext<AddressesDbContext>(opts =>
        opts.UseSqlServer(builder.Configuration.GetConnectionString("Database")));
builder.Services.AddScoped<IAddressesRepository, AddressesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

FillDb.Fill(app);
