using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Enums;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IProductService,ProductManager>();
builder.Services.AddSingleton<IProductDal,EfProductDal>();
builder.Services.AddSingleton<ICategoryService,CategoryManager>();
builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();
builder.Services.AddSingleton<IUserService,UserManager>();
builder.Services.AddSingleton<IUserDal,EfUserDal>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
