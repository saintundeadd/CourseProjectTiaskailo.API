using CourseProject.BLL.Interfaces;
using CourseProject.BLL.Services;
using CourseProject.Core.Entities;
using CourseProject.DAL.Data;
using CourseProject.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Додайте рядок підключення до бази даних
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<CourseProjectDbContext>(options =>
    options.UseSqlServer(connectionString));

// Додайте ваші сервіси і репозиторії
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IBoilerService, BoilerService>();
builder.Services.AddScoped<ISensorService<TemperatureSensor>, SensorService<TemperatureSensor>>();

// Інші необхідні налаштування
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();