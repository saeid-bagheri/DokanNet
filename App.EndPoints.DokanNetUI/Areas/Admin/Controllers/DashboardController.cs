using App.Domain.Core.AppServices.Admins.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    [Authorize(Roles ="AdminRole")]
    public class DashboardController : Controller
    {


        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
