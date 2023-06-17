using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Admins.Commands;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using App.EndPoints.DokanNetUI.Controllers;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Controllers
{
    [Area("Seller")]
    public class DashboardController : Controller
    {
        private readonly IGetCities _getCities;
        private readonly IMapper _mapper;
        private readonly ICreateSeller _createSeller;
        private readonly ICreateStore _createStore;
        private readonly IGetUserRolesByUserName _getUserRolesByUserName;
        private readonly IGetStoreById _getStoreById;
        private readonly IGetSellerById _getSellerById;

        public DashboardController(IGetCities getCities, IMapper mapper,
                               ICreateSeller createSeller, IGetUserRolesByUserName getUserRolesByUserName,
                               ICreateStore createStore, IGetStoreById getStoreById, IGetSellerById getSellerById)
        {
            _getCities = getCities;
            _mapper = mapper;
            _createSeller = createSeller;
            _getUserRolesByUserName = getUserRolesByUserName;
            _createStore = createStore;
            _getStoreById = getStoreById;
            _getSellerById = getSellerById;
        }

        [Authorize(Roles ="SellerRole")]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var seller = await _getSellerById.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);
            var store = await _getStoreById.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);
            var sellerStore = new DashboardVM()
            {
                Id = Convert.ToInt32(seller.Id),
                FirstName = seller.FirstName,
                LastName = seller.LastName,
                Mobile = seller.Mobile,
                CardNumber = seller.CardNumber,
                ShebaNumber = seller.ShebaNumber,
                CityName = seller.City.Title,
                Birthday = seller.Birthday,
                CreatedAt = seller.CreatedAt,
                Biography = seller.Biography,
                Address = seller.Address,
                ProfileImgUrl = seller.ProfileImgUrl,
                StoreTitle = store.Title,
                Products = store.Products
            };
            return View(sellerStore);
        }


        public async Task<IActionResult> Create(CancellationToken cancellationToken)
        {
            var createStoreVM = new CreateSellerAndStoreVM();
            createStoreVM.Cities = await _getCities.Execute(cancellationToken);
            return View(createStoreVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSellerAndStoreVM createSellerAndStoreVM, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                if (!(await _getUserRolesByUserName.Execute(User.Identity.GetUserName(), cancellationToken)).Contains("SellerRole"))
                {
                    createSellerAndStoreVM.Id = Convert.ToInt32(User.Identity.GetUserId());
                    await _createSeller.Execute(_mapper.Map<SellerDto>(createSellerAndStoreVM), cancellationToken);
                    await _createStore.Execute(_mapper.Map<StoreDto>(createSellerAndStoreVM), cancellationToken);
                }
            }
            return RedirectToAction("Index");
        }






    }
}
