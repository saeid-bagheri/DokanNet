using App.Domain.Core.Services.Buyers.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.AutoMapper
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private readonly IGetParentCategories _getParentCategories;
        private readonly IMapper _mapper;

        public CategoriesMenuViewComponent(IGetParentCategories getParentCategories, IMapper mapper)
        {
            _getParentCategories = getParentCategories;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(CancellationToken cancellationToken)
        {
            var categories = _mapper.Map<List<BuyerCategoryVM>>(await _getParentCategories.Execute(cancellationToken));
            return View(categories);
        }


    }
}