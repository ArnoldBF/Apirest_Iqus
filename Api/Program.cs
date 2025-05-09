using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using Application.Interfaces;
using Infrastructure.Repository;
using Application.Services;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();


builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

app.Run();

