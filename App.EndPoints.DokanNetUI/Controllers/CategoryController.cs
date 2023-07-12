using App.Domain.Core.Services.Buyers.Queries;
using App.Domain.Service.Buyers.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetCategoryById _getCategoryById;
        private readonly IGetProductsForCategoryAndSubcategories _getProductsByCategoryAndSubcategories;

        public CategoryController(IMapper mapper, IGetCategoryById getCategoryById,
                                  IGetProductsForCategoryAndSubcategories getProductsByCategoryAndSubcategories)
        {
            _mapper = mapper;
            _getCategoryById = getCategoryById;
            _getProductsByCategoryAndSubcategories = getProductsByCategoryAndSubcategories;
        }

        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var buyerCategoryVM = _mapper.Map<BuyerCategoryVM>(await _getCategoryById.Execute(id, cancellationToken));
            buyerCategoryVM.Products = await _getProductsByCategoryAndSubcategories.Execute(id, cancellationToken);
            return View(buyerCategoryVM);
        }
    }
}
