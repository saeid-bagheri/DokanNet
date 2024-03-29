using App.Domain.Core.Configs;
using App.Domain.Core.DataAccess;
using App.Domain.Core.Entities;
using App.Domain.Service._IocConfigs;
using App.EndPoints.DokanNetUI.AutoMapper;
using App.EndPoints.DokanNetUI.CustomMiddleWares;
using App.Infrastructures.Data.Repositories.AutoMapper;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
using Hangfire;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using App.Infrastructures.Data.Repositories._IocConfigs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<CustomExceptionMiddleware>();

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
//extention methods for config dependency injection
builder.Services.Add_Sevices();
builder.Services.Add_Repositories();
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



//Execption Heandling
app.UseMiddleware<CustomExceptionMiddleware>();



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
