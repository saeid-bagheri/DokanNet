using App.Domain.Core.Entities;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public HomeController(ILogger<HomeController> logger,
                              UserManager<AppUser> userManager,
                              RoleManager<IdentityRole<int>> roleManager)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> SeedData()
        {
            var adminRoleResult = await _roleManager.CreateAsync(new IdentityRole<int>("AdminRole"));
            var buyerRoleResult = await _roleManager.CreateAsync(new IdentityRole<int>("BuyerRole"));
            var sellerRoleResult = await _roleManager.CreateAsync(new IdentityRole<int>("SellerRole"));
            var password = "1234";

            var adminUserResult = await _userManager.CreateAsync(new AppUser()
            {
                UserName = "Admin-01",
                PasswordHash = password.GetHashCode().ToString()
            });

            if (adminUserResult.Succeeded)
            {
                var adminUser = await _userManager.FindByNameAsync("Admin-01");
                await _userManager.AddToRoleAsync(adminUser, "AdminRole");
            }

            var testUserResult = await _userManager.CreateAsync(new AppUser()
            {
                UserName = "test-01"
            });

            if (testUserResult.Succeeded)
            {
                var testUser = await _userManager.FindByNameAsync("test-01");
                await _userManager.AddToRoleAsync(testUser, "BuyerRole");
            }

            return Ok();
 
        }
    }
}