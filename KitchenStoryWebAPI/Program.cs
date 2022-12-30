using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;
using KitchenStoryCore.CoreServices.Services.ProductCategoryServices;
using KitchenStoryCore.Repository.ProductCategoryRepo;
using KitchenStoryInfrastructure.Data;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using KitchenStoryInfrastructure.Repositories.ProductCategoryRepo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<KitchenStory_DbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("KitchenStoryDbConnectionString"));
    
    });


builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryGetRepository), typeof(ProductCategoryGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryGetService), typeof(ProductCategoryGetService), ServiceLifetime.Transient));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
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
