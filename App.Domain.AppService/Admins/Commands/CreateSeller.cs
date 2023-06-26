using App.Domain.Core.Configs;
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
        private readonly SignInManager<AppUser> _signInManager;
        private readonly Medalconfig _medalconfig;

        public CreateSeller(UserManager<AppUser> userManager, ISellerRepository sellerRepository,
                            IBuyerRepository buyerRepository, SignInManager<AppUser> signInManager,
                            Medalconfig medalconfig)
        {
            _userManager = userManager;
            _sellerRepository = sellerRepository;
            _buyerRepository = buyerRepository;
            _signInManager = signInManager;
            _medalconfig = medalconfig;
        }


        public async Task Execute(SellerDto entity, CancellationToken cancellationToken)
        {
            //add seller role to user roles
            var user = await _userManager.FindByIdAsync(entity.Id.ToString());
            await _userManager.AddToRoleAsync(user, "SellerRole");

            //add role to coockie
            await _signInManager.RefreshSignInAsync(user);


            //create new seller
            entity.IsDeleted = false;
            entity.CreatedAt = DateTime.Now;
            entity.FeePercentage = _medalconfig.FeePercentageDefault;
            await _sellerRepository.Create(entity, cancellationToken);


            //update buyer of this user
            var buyer = new BuyerDto()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Mobile = entity.Mobile,
                Address = entity.Address,
                CityId = entity.CityId
            };
            await _buyerRepository.Update(buyer, cancellationToken);
        }
    }
}
