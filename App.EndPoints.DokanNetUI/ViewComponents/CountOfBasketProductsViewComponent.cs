using App.Domain.Core.Services.Buyers.Queries;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.ViewComponents
{
    public class CountOfBasketProductsViewComponent : ViewComponent
    {
        private readonly IGetCountOfBasketProductsByBuyerId _getCountOfBasketProductsByBuyerId;

        public CountOfBasketProductsViewComponent(IGetCountOfBasketProductsByBuyerId getCountOfBasketProductsByBuyerId)
        {
            _getCountOfBasketProductsByBuyerId = getCountOfBasketProductsByBuyerId;
        }

        public async Task<IViewComponentResult> InvokeAsync(CancellationToken cancellationToken)
        {
            var count = await _getCountOfBasketProductsByBuyerId.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);
            return View(count);
        }

    }
}
