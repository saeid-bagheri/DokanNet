using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Commands
{
    public class UpdateSellerProfile : IUpdateSellerProfile
    {
        private readonly ISellerRepository _sellerRepository;

        public UpdateSellerProfile(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }
        public async Task Execute(SellerDto entity, CancellationToken cancellationToken)
        {
            await _sellerRepository.Update(entity, cancellationToken);
        }
    }
}
