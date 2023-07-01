using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Common.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class GetSellerById : IGetSellerById
    {
        private readonly ISellerRepository _sellerRepository;

        public GetSellerById(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }
        public async Task<SellerDto> Execute(int id, CancellationToken cancellationToken)
        {
            return await _sellerRepository.GetById(id, cancellationToken);
        }
    }
}
