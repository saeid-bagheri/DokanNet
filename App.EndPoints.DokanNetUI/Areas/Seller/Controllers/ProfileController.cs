using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
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
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var seller = await _getSellerById.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);
            var profile = new SellerProfileVM()
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
                ProfileImgUrl = seller.ProfileImgUrl
            };
            return View(profile);
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
        public async Task<IActionResult> Update(UpdateSellerProfileVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateSellerProfile.Execute(_mapper.Map<SellerDto>(model), cancellationToken);
                return RedirectToAction("Index", "Profile");
            }
            return View(model);
        }
    }
}
