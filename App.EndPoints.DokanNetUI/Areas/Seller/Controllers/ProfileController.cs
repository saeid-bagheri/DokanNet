using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize(Roles ="SellerRole")]
    public class ProfileController : Controller
    {
        private readonly IGetSellerById _getSellerById;
        private readonly IGetCities _getCities;
        private readonly IUpdateSellerProfile _updateSellerProfile;
        private readonly IMapper _mapper;

        public ProfileController(IGetSellerById getSellerById, IGetCities getCities,
                                 IUpdateSellerProfile updateSellerProfile, IMapper mapper)
        {
            _getSellerById = getSellerById;
            _getCities = getCities;
            _updateSellerProfile = updateSellerProfile;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var seller = await _getSellerById.Execute(id, cancellationToken);
            var updateSellerVM = new UpdateSellerProfileVM()
            {
                Id = seller.Id,
                FirstName = seller.FirstName,
                LastName = seller.LastName,
                Mobile = seller.Mobile,
                CardNumber = seller.CardNumber,
                ShebaNumber = seller.ShebaNumber,
                Birthday = seller.Birthday,
                Biography = seller.Biography,
                CityId = seller.CityId,
                Cities = await _getCities.Execute(cancellationToken),
                Address = seller.Address,
                ProfileImgUrl = seller.ProfileImgUrl
            };
            return View(updateSellerVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateSellerProfileVM updateSellerProfileVM, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateSellerProfile.Execute(_mapper.Map<SellerDto>(updateSellerProfileVM), cancellationToken);
            }
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
