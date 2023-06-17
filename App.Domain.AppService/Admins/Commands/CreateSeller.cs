using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Admins.Commands;
using App.Infrastructures.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Admins.Commands
{
    public class CreateSeller : ICreateSeller
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IBuyerRepository _buyerRepository;
        private readonly UserManager<AppUser> _userManager;

        public CreateSeller(UserManager<AppUser> userManager, ISellerRepository sellerRepository,
                            IBuyerRepository buyerRepository)
        {
            _userManager = userManager;
            _sellerRepository = sellerRepository;
            _buyerRepository = buyerRepository;
        }


        public async Task Execute(SellerDto model, CancellationToken cancellationToken)
        {
            //add seller role tp user roles
            var user = await _userManager.FindByIdAsync(model.Id.ToString());
            await _userManager.AddToRoleAsync(user, "SellerRole");

            //create new seller
            model.IsDeleted = false;
            model.CreatedAt = DateTime.Now;
            //add this in appSetting
            model.FeePercentage = 5;
            await _sellerRepository.Create(model, cancellationToken);

            //update buyer of this user
            var buyer = new BuyerDto()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Mobile = model.Mobile,
                Address = model.Address,
                CityId = model.CityId
            };
            await _buyerRepository.Update(buyer, cancellationToken);
        }
    }
}
