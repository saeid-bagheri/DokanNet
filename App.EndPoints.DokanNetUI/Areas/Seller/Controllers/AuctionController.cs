using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Admins.Commands;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using AutoMapper;
using Hangfire;
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
        private readonly IReduceProductStock _reduceProductStock;
        private readonly IEndOfAuction _endOfAuction;
        private readonly IBackgroundJobClient _backgroundJobClient;

        public AuctionController(IMapper mapper, IGetAuctionsByStoreId getAuctionsByStore,
                                 ICreateAuction createAuction, IGetProductById getProductById,
                                 IGetAuctionProductsByStoreId getAuctionProductsByStore,
                                 IReduceProductStock reduceProductStock, IEndOfAuction endOfAuction,
                                 IBackgroundJobClient backgroundJobClient)
        {
            _mapper = mapper;
            _getAuctionsByStore = getAuctionsByStore;
            _createAuction = createAuction;
            _getProductById = getProductById;
            _getAuctionProductsByStore = getAuctionProductsByStore;
            _reduceProductStock = reduceProductStock;
            _endOfAuction = endOfAuction;
            _backgroundJobClient = backgroundJobClient;
        }


        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var auctions = _mapper.Map<List<SellerAuctionVM>>(await _getAuctionsByStore.Execute(id, cancellationToken));
            TempData["StoreId"] = id;
            return View(auctions);
        }


        public async Task<IActionResult> Create(int id, CancellationToken cancellationToken)
        {
            var sellerAuctionVM = new SellerCreateAuctionVM()
            {
                StoreId = id,
                Products = await _getAuctionProductsByStore.Execute(id, cancellationToken)
            };
            return View(sellerAuctionVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SellerCreateAuctionVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                //The number of auction products should not be more than the number of warehouse products
                if (model.CountOfProducts <= (await _getProductById.Execute(model.ProductId, cancellationToken)).Stock)
                {
                    //start time should not be more than the end time
                    if (model.StartTime < model.EndTime)
                    {
                        //create auction
                        var auctionId = await _createAuction.Execute(_mapper.Map<AuctionDto>(model), cancellationToken);

                        //Reducing the number of stock products to the amount of auction products
                        await _reduceProductStock.Execute(model.CountOfProducts, model.ProductId, cancellationToken);

                        //run end of auction with hangfire
                        _backgroundJobClient.Schedule(() => _endOfAuction.Execute(auctionId, cancellationToken), (model.EndTime - model.StartTime).Value);

                        return RedirectToAction("Index", new { id = model.StoreId });

                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "زمان شروع باید از زمان پایان کوچکتر باشد");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "تعداد محصول مزایده نباید از موجودی انبار بیشتر باشد");
                }

            }
            model.Products = await _getAuctionProductsByStore.Execute(model.StoreId, cancellationToken);
            return View(model);
        }
    }
}
