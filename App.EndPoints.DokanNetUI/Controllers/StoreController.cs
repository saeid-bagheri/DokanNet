using App.Domain.Core.Services.Common.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class StoreController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetStoreById _getStoreById;
        private readonly IGetProductsByStoreId _getProductsByStoreId;
        private readonly IGetSellerById _getSellerById;

        public StoreController(IMapper mapper, IGetStoreById getStoreById,
                               IGetProductsByStoreId getProductsByStoreId, IGetSellerById getSellerById)
        {
            _mapper = mapper;
            _getStoreById = getStoreById;
            _getProductsByStoreId = getProductsByStoreId;
            _getSellerById = getSellerById;
        }

        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var buyerStoreVM = _mapper.Map<BuyerStoreVM>(await _getStoreById.Execute(id, cancellationToken));
            buyerStoreVM.Products = await _getProductsByStoreId.Execute(id, cancellationToken);
            buyerStoreVM.Seller = await _getSellerById.Execute(id, cancellationToken);
            return View(buyerStoreVM);
        }
    }
}
