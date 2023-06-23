using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize(Roles = "SellerRole")]
    public class AuctionController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetAuctionsByStoreId _getAuctionsByStore;
        private readonly IGetAuctionProductsByStoreId _getAuctionProductsByStore;
        private readonly ICreateAuction _createAuction;
        private readonly IGetProductById _getProductById;

        public AuctionController(IMapper mapper, IGetAuctionsByStoreId getAuctionsByStore,
                                 ICreateAuction createAuction,IGetProductById getProductById,
                                 IGetAuctionProductsByStoreId getAuctionProductsByStore)
        {
            _mapper = mapper;
            _getAuctionsByStore = getAuctionsByStore;
            _createAuction = createAuction;
            _getProductById = getProductById;
            _getAuctionProductsByStore = getAuctionProductsByStore;
        }


        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var auctions = _mapper.Map<List<SellerAuctionVM>>(await _getAuctionsByStore.Execute(id, cancellationToken));
            TempData["StoreId"] = id;
            return View(auctions);
        }


        public async Task<IActionResult> Create(int id, CancellationToken cancellationToken)
        {
            var sellerAuctionVM = new SellerAuctionVM()
            {
                StoreId = id,
                Products = await _getAuctionProductsByStore.Execute(id, cancellationToken)
            };
            return View(sellerAuctionVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SellerAuctionVM model, CancellationToken cancellationToken)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors); //to check the errors
            if (ModelState.IsValid)
            {
                //The number of auction products should not be more than the number of warehouse products
                if (model.CountOfProducts <= (await _getProductById.Execute(model.ProductId, cancellationToken)).Stock)
                {
                    //create auction
                    await _createAuction.Execute(_mapper.Map<AuctionDto>(model), cancellationToken);
                    //Reducing the number of stock products to the amount of auction products



                    return RedirectToAction("Index", new { id = model.StoreId });
                }
            }
            return View();
        }
    }
}
