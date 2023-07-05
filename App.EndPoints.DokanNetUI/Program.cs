using App.Domain.AppService.Admins.Commands;
using App.Domain.AppService.Admins.Queries;
using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.AppServices.Sellers.Commands;
using App.Domain.Core.Configs;
using App.Domain.Core.DataAccess;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Admins.Commands;
using App.Domain.Core.Services.Admins.Queries;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Buyers.Commands;
using App.Domain.Core.Services.Buyers.Queries;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Common.Queries;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.Domain.Service.Admins.Commands;
using App.Domain.Service.Admins.Queries;
using App.Domain.Service.Application.Queries;
using App.Domain.Service.Buyers.Commands;
using App.Domain.Service.Buyers.Queries;
using App.Domain.Service.Common.Commands;
using App.Domain.Service.Common.Queries;
using App.Domain.Service.Sellers.Commands;
using App.Domain.Service.Sellers.Queries;
using App.EndPoints.DokanNetUI.AutoMapper;
using App.Infrastructures.Data.Repositories;
using App.Infrastructures.Data.Repositories.AutoMapper;
using App.Infrastructures.Data.Repositories.Repositories;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.ConfigureApplicationCookie(options =>
{
    //send user to a page that said your access is denied!
    options.AccessDeniedPath = "/";

});



#region config from appsetting
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.Development.json");

var connectionString = builder.Configuration.GetSection("ConnectionString").Value;
var medalConfig = builder.Configuration.GetSection("MedalConfig").Get<MedalConfig>();
builder.Services.AddSingleton(medalConfig);
#endregion config from appsetting


#region dependency injection

//Common
builder.Services.AddScoped<IGetCities, GetCities>();
builder.Services.AddScoped<IGetCategories, GetCategories>();
builder.Services.AddScoped<IUpdateProduct, UpdateProduct>();
builder.Services.AddScoped<ICreateInvoice, CreateInvoice>();
builder.Services.AddScoped<IGetLastPriceOfAuction, GetLastPriceOfAuction>();
builder.Services.AddScoped<IAddImageToProduct, AddImageToProduct>();
builder.Services.AddScoped<IReduceProductStock, ReduceProductStock>();
builder.Services.AddScoped<IAddProductStock, AddProductStock>();
builder.Services.AddScoped<ICalculateSiteCommissionPercent, CalculateSiteCommissionPercent>();

//admins
builder.Services.AddScoped<ICloseStore, CloseStore>();
builder.Services.AddScoped<IConfirmComment, ConfirmComment>();
builder.Services.AddScoped<IConfirmProduct, ConfirmProduct>();
builder.Services.AddScoped<IDeleteProduct, DeleteProduct>();
builder.Services.AddScoped<IDeleteUser, DeleteUser>();
builder.Services.AddScoped<ILoginUser, LoginUser>();
builder.Services.AddScoped<IRegisterUser, RegisterUser>();
builder.Services.AddScoped<IUpdateStore, UpdateStore>();
builder.Services.AddScoped<IUpdateUser, UpdateUser>();
builder.Services.AddScoped<IGetComments, GetComments>();
builder.Services.AddScoped<IGetProductById, GetProductById>();
builder.Services.AddScoped<IGetProducts, GetProducts>();
builder.Services.AddScoped<IGetStoreById, GetStoreById>();
builder.Services.AddScoped<IGetStores, GetStores>();
builder.Services.AddScoped<IGetUserById, GetUserById>();
builder.Services.AddScoped<IGetUserRolesByHttp, GetUserRolesByHttp>();
builder.Services.AddScoped<IGetUserRolesByUserName, GetUserRolesByUserName>();
builder.Services.AddScoped<IGetUsers, GetUsers>();
builder.Services.AddScoped<IGetInvoices, GetInvoices>();
builder.Services.AddScoped<ICreateSeller, CreateSeller>();
builder.Services.AddScoped<IAddRoleToUser, AddRoleToUser>();
builder.Services.AddScoped<IEndOfAuction, EndOfAuction>();

//sellers
builder.Services.AddScoped<ICreateStore, CreateStore>();
builder.Services.AddScoped<IGetSellerById, GetSellerById>();
builder.Services.AddScoped<IUpdateSellerProfile, UpdateSellerProfile>();
builder.Services.AddScoped<IGetProductsByStoreId, GetProductsByStoreId>();
builder.Services.AddScoped<ICreateProduct, CreateProduct>();
builder.Services.AddScoped<IAddCategory, AddCategory>();
builder.Services.AddScoped<IGetAuctionsByStoreId, GetAuctionsByStoreId>();
builder.Services.AddScoped<ICreateAuction, CreateAuction>();
builder.Services.AddScoped<IGetAuctionProductsByStoreId, GetAuctionProductsByStoreId>();
builder.Services.AddScoped<IIsExistProductInStoreByName, IsExistProductInStoreByName>();
builder.Services.AddScoped<IUpdateMedal, UpdateMedal>();
builder.Services.AddScoped<IGetSellerByProductId, GetSellerByProductId>();

//buyers
builder.Services.AddScoped<IGetOpenAuctions, GetOpenAuctions>();
builder.Services.AddScoped<ICreateBid, CreateBid>();
builder.Services.AddScoped<ILosingBidsInAuction, LosingBidsInAuction>();
builder.Services.AddScoped<IGetNormalProducts, GetNormalProducts>();
builder.Services.AddScoped<IGetBasketByBuyerId, GetBasketByBuyerId>();
builder.Services.AddScoped<ICreateBasket, CreateBasket>();
builder.Services.AddScoped<IAddProductToBasket, AddProductToBasket>();
builder.Services.AddScoped<IGetCountOfBasketProductsByBuyerId, GetCountOfBasketProductsByBuyerId>();
builder.Services.AddScoped<IReduceProductFromBasket, ReduceProductFromBasket>();
builder.Services.AddScoped<IFinalizePurchase, FinalizePurchase>();
builder.Services.AddScoped<IGetBuyerById, GetBuyerById>();
builder.Services.AddScoped<IUpdateBuyer, UpdateBuyer>();
builder.Services.AddScoped<IGetInvoicesByBuyerId, GetInvoicesByBuyerId>();
builder.Services.AddScoped<IGetParentCategories, GetParentCategories>();
builder.Services.AddScoped<IGetProductsByCategoryAndSubcategories, GetProductsByCategoryAndSubcategories>();
builder.Services.AddScoped<IGetCategoryById, GetCategoryById>();


//repositories
builder.Services.AddScoped<IAuctionRepository, AuctionRepository>();
builder.Services.AddScoped<IBidRepository, BidRepository>();
builder.Services.AddScoped<IBuyerRepository, BuyerRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
builder.Services.AddScoped<IMedalRepository, MedalRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ISellerRepository, SellerRepository>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IInvoiceProductRepository, InvoiceProductRepository>();

#endregion dependency injection
#region config dbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
#endregion  config dbContext
#region config identity
builder.Services.AddIdentity<AppUser, IdentityRole<int>>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<AppDbContext>();
#endregion config identity
#region config autoMapper
var configMapper = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMappingInfrastructures());
    cfg.AddProfile(new AutoMappingUI());
});
var mapper = configMapper.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion config autoMapper
#region config hangfire
builder.Services.AddHangfire(configuration => configuration
    .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage(connectionString));

builder.Services.AddHangfireServer();

#endregion config hangfire

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapAreaControllerRoute(
    areaName: "Admin",
    name: "Areas",
    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    areaName: "Seller",
    name: "Areas",
    pattern: "Seller/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
