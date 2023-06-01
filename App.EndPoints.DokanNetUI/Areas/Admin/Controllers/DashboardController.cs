using App.Domain.Core.AppServices.Admins.Queries;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IGetUsers _getUsers;

        public DashboardController(IGetUsers getUsers)
        {
            _getUsers = getUsers;
        }


        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }


        [Area("Admin")]
        public async Task<IActionResult> Users(CancellationToken cancellationToken)
        {
            var users = await _getUsers.Execute(cancellationToken);
            return View(users);
        }
    }
}
