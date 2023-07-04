using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Buyers.Commands;
using App.Domain.Core.Services.Buyers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using App.Infrastructures.Data.Repositories;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace App.EndPoints.DokanNetUI.Controllers
{
    [Authorize]
    public class BuyerProfileController : Controller
    {
        private readonly IGetBuyerById _getBuyerById;
        private readonly IUpdateBuyer _updateBuyer;
        private readonly IGetCities _getCities;
        private readonly IMapper _mapper;
        private readonly IGetInvoicesByBuyerId _getInvoicesByBuyerId;

        public BuyerProfileController(IGetBuyerById getBuyerById, IMapper mapper,
                                      IGetCities getCities, IUpdateBuyer updateBuyer,
                                      IGetInvoicesByBuyerId getInvoicesByBuyerId)
        {
            _getBuyerById = getBuyerById;
            _updateBuyer = updateBuyer;
            _getCities = getCities;
            _mapper = mapper;
            _getInvoicesByBuyerId = getInvoicesByBuyerId;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var buyerDto = await _getBuyerById.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);
            var buyerVM = new BuyerProfileVM();
            _mapper.Map(buyerDto, buyerVM);
            //get buyer invoices
            buyerVM.Invoices = await _getInvoicesByBuyerId.Execute(buyerVM.Id, cancellationToken);
            return View(buyerVM);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var buyer = await _getBuyerById.Execute(id, cancellationToken);
            var updateBuyerVM = new UpdateBuyerProfileVM()
            {
                Id = buyer.Id,
                FirstName = buyer.FirstName,
                LastName = buyer.LastName,
                Mobile = buyer.Mobile,
                CityId = buyer.CityId,
                Cities = await _getCities.Execute(cancellationToken),
                Address = buyer.Address,
                ProfileImgUrl = buyer.ProfileImgUrl
            };
            return View(updateBuyerVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBuyerProfileVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateBuyer.Execute(_mapper.Map<BuyerDto>(model), cancellationToken);
                return RedirectToAction("Index", "BuyerProfile");
            }
            return View(model);
        }

    }
}
