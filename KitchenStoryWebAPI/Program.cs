using KitchenStoryCore.CoreServices.Contracts.ProductCategoryContracts;
using KitchenStoryCore.CoreServices.Services.ProductCategoryServices;
using KitchenStoryCore.Repository.ProductCategoryRepo;
using KitchenStoryInfrastructure.Repositories.ProductCategoryRepo;

using KitchenStoryCore.CoreServices.Contracts.ProductSubCategoryContracts;
using KitchenStoryCore.CoreServices.Services.ProductSubCatagoryServices;
using KitchenStoryCore.Repository.ProductSubCategoryRepo;
using KitchenStoryInfrastructure.Repositories.ProductSubCategoryRepo;


using KitchenStoryCore.CoreServices.Contracts.BrandContracts;
using KitchenStoryCore.CoreServices.Services.BrandServices;
using KitchenStoryCore.Repository.BrandRepo;
using KitchenStoryInfrastructure.Repositories.BrandRepo;

using KitchenStoryCore.CoreServices.Contracts.ProductContracts;
using KitchenStoryCore.CoreServices.Services.ProductServices;
using KitchenStoryCore.Repository.ProductRepo;
using KitchenStoryInfrastructure.Repositories.ProductRepo;


using KitchenStoryCore.CoreServices.Contracts.OrderContracts;
using KitchenStoryCore.CoreServices.Services.OrderServices;
using KitchenStoryCore.Repository.OrderRepo;
using KitchenStoryInfrastructure.Repositories.OrderRepo;


using KitchenStoryCore.CoreServices.Contracts.OrderContactDetailContracts;
using KitchenStoryCore.CoreServices.Services.OrderContactDetailServices;
using KitchenStoryCore.Repository.OrderContactDetailRepo;
using KitchenStoryInfrastructure.Repositories.OrderContactDetailRepo;


using KitchenStoryCore.CoreServices.Contracts.OrderDetailContracts;
using KitchenStoryCore.CoreServices.Services.OrderDetailServices;
using KitchenStoryCore.Repository.OrderDetailRepo;
using KitchenStoryInfrastructure.Repositories.OrderDetailRepo;


using KitchenStoryCore.DomainModel;
using KitchenStoryCore.CoreServices.Contracts.OrderAddressContracts;
using KitchenStoryCore.CoreServices.Services.OrderAddressServices;
using KitchenStoryCore.Repository.OrderAddressRepo;
using KitchenStoryInfrastructure.Repositories.OrderAddressRepo;



using KitchenStoryCore.CoreServices.Contracts.UserContracts;
using KitchenStoryCore.CoreServices.Services.UserServices;
using KitchenStoryCore.Repository.UserRepo;
using KitchenStoryInfrastructure.Repositories.UserRepo;



using KitchenStoryInfrastructure.Data;
using KitchenStoryInfrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<KitchenStory_DbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("KitchenStoryDbConnectionString"));
    
    });

builder.Services.AddDbContext<KitchenStory_UserDBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("KitchenStoryDbConnectionString"));

});


builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryGetRepository), typeof(ProductCategoryGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryGetService), typeof(ProductCategoryGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryUpdateRepository), typeof(ProductCategoryUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryUpdateService), typeof(ProductCategoryUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryDeleteRepository), typeof(ProductCategoryDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryDeleteService), typeof(ProductCategoryDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryInsertRepository), typeof(ProductCategoryInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductCategoryInsertService), typeof(ProductCategoryInsertService), ServiceLifetime.Transient));


builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryGetRepository), typeof(ProductSubCategoryGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryGetService), typeof(ProductSubCategoryGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryUpdateRepository), typeof(ProductSubCategoryUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryUpdateService), typeof(ProductSubCategoryUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryDeleteRepository), typeof(ProductSubCategoryDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryDeleteService), typeof(ProductSubCategoryDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryInsertRepository), typeof(ProductSubCategoryInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductSubCategoryInsertService), typeof(ProductSubCategoryInsertService), ServiceLifetime.Transient));



builder.Services.Add(new ServiceDescriptor(typeof(IBrandGetRepository), typeof(BrandGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandGetService), typeof(BrandGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandUpdateRepository), typeof(BrandUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandUpdateService), typeof(BrandUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandDeleteRepository), typeof(BrandDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandDeleteService), typeof(BrandDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandInsertRepository), typeof(BrandInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IBrandInsertService), typeof(BrandInsertService), ServiceLifetime.Transient));




builder.Services.Add(new ServiceDescriptor(typeof(IProductGetRepository), typeof(ProductGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductGetService), typeof(ProductGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductUpdateRepository), typeof(ProductUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductUpdateService), typeof(ProductUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductDeleteRepository), typeof(ProductDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductDeleteService), typeof(ProductDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductInsertRepository), typeof(ProductInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IProductInsertService), typeof(ProductInsertService), ServiceLifetime.Transient));



builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailGetRepository), typeof(OrderContactDetailGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailGetService), typeof(OrderContactDetailGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailUpdateRepository), typeof(OrderContactDetailUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailUpdateService), typeof(OrderContactDetailUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailDeleteRepository), typeof(OrderContactDetailDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailDeleteService), typeof(OrderContactDetailDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailInsertRepository), typeof(OrderContactDetailInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderContactDetailInsertService), typeof(OrderContactDetailInsertService), ServiceLifetime.Transient));



builder.Services.Add(new ServiceDescriptor(typeof(IOrderGetRepository), typeof(OrderGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderGetService), typeof(OrderGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderUpdateRepository), typeof(OrderUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderUpdateService), typeof(OrderUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDeleteRepository), typeof(OrderDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDeleteService), typeof(OrderDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderInsertRepository), typeof(OrderInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderInsertService), typeof(OrderInsertService), ServiceLifetime.Transient));



builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailGetRepository), typeof(OrderDetailGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailGetService), typeof(OrderDetailGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailUpdateRepository), typeof(OrderDetailUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailUpdateService), typeof(OrderDetailUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailDeleteRepository), typeof(OrderDetailDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailDeleteService), typeof(OrderDetailDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailInsertRepository), typeof(OrderDetailInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderDetailInsertService), typeof(OrderDetailInsertService), ServiceLifetime.Transient));




builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressGetRepository), typeof(OrderAddressGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressGetService), typeof(OrderAddressGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressUpdateRepository), typeof(OrderAddressUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressUpdateService), typeof(OrderAddressUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressDeleteRepository), typeof(OrderAddressDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressDeleteService), typeof(OrderAddressDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressInsertRepository), typeof(OrderAddressInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IOrderAddressInsertService), typeof(OrderAddressInsertService), ServiceLifetime.Transient));




builder.Services.Add(new ServiceDescriptor(typeof(IUserGetRepository), typeof(UserGetRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserGetService), typeof(UserGetService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserUpdateRepository), typeof(UserUpdateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserUpdateService), typeof(UserUpdateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserDeleteRepository), typeof(UserDeleteRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserDeleteService), typeof(UserDeleteService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserInsertRepository), typeof(UserInsertRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserInsertService), typeof(UserInsertService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserAuthenticateRepository), typeof(UserAuthenticateRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserAuthenticateService), typeof(UserAuthenticateService), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserTokenHandlerRepository), typeof(UserTokenHandlerRepository), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IUserTokenHandlerService), typeof(UserTokenHandlerService), ServiceLifetime.Transient));








builder.Services.AddFluentValidation(options => options.RegisterValidatorsFromAssemblyContaining<Program>());
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = builder.Configuration["Jwt:Issuer"],
    ValidAudience = builder.Configuration["Jwt:Audience"],
    IssuerSigningKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))


});

var ibuilder = builder.Services.AddIdentityCore<User>(opt=> {
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 4;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireUppercase = false;
});

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<KitchenStory_UserDBContext>();

builder.Services.AddAutoMapper(typeof(Program).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
