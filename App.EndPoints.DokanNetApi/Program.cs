using App.Domain.Core.Configs;
using App.Domain.Core.Entities;
using App.Infrastructures.Data.Repositories.AutoMapper;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using App.Domain.Service._IocConfigs;
using App.Infrastructures.Data.Repositories._IocConfigs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
});
var mapper = configMapper.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion config autoMapper


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
