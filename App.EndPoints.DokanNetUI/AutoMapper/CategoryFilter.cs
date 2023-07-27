using App.Domain.Core.Services.Buyers.Queries;
using Microsoft.AspNetCore.Mvc.Filters;

namespace App.EndPoints.DokanNetUI.AutoMapper
{
    public class CategoryFilter : IActionFilter
    {
        private readonly IGetParentCategories _getParentCategories;

        public CategoryFilter(IGetParentCategories getParentCategories)
        {
            _getParentCategories = getParentCategories;
        }

        public async void OnActionExecuting(ActionExecutedContext context, CancellationToken cancellationToken)
        {
            // get categories
            var categories = await _getParentCategories.Execute(cancellationToken);
            // store it in HttpContext.Items
            context.HttpContext.Items["Categories"] = categories;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
