using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
