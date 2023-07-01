using App.Domain.Core.Configs;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Commands;
using App.Domain.Core.Services.Buyers.Queries;
using App.Domain.Core.Services.Common.Queries;
using App.Domain.Service.Sellers.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Controllers
{
    [Authorize]
    public class BidController : Controller
    {
        private readonly ICreateBid _createBid;
        private readonly IMapper _mapper;
        private readonly IGetLastPriceOfAuction _getLastPriceOfAuction;
        private readonly ILosingBidsInAuction _losingBidsInAuction;

        public BidController(ICreateBid createBid, IMapper mapper,
                             IGetLastPriceOfAuction getLastPriceOfAuction, ILosingBidsInAuction losingBidsInAuction)
        {
            _createBid = createBid;
            _mapper = mapper;
            _getLastPriceOfAuction = getLastPriceOfAuction;
            _losingBidsInAuction = losingBidsInAuction;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create(int id, CancellationToken cancellationToken)
        {
            var bidVM = new BidVM()
            {
                AuctionId = id,
                BuyerId = Convert.ToInt32(User.Identity.GetUserId()),
                Price = await _getLastPriceOfAuction.Execute(id, cancellationToken)
            };
            TempData["LastPrice"] = bidVM.Price;
            return View(bidVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BidVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                if (model.Price > await _getLastPriceOfAuction.Execute(model.AuctionId, cancellationToken))
                {
                    //Losing all bids in this auction
                    await _losingBidsInAuction.Execute(model.AuctionId, cancellationToken);

                    //create new bid for this auction
                    await _createBid.Execute(_mapper.Map<BidDto>(model), cancellationToken);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "قیمت پیشنهادی باید از آخرین قیمت مزایده بالاتر باشد");
                }
            }
            return View(model);
        }
    }
}
