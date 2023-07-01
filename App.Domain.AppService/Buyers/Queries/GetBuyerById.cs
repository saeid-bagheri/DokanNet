using App.Domain.Core.Services.Buyers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetBuyerById : IGetBuyerById
    {
        private readonly IBuyerRepository _buyerRepository;

        public GetBuyerById(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public async Task<BuyerDto> Execute(int id, CancellationToken cancellationToken)
        {
            return await _buyerRepository.GetById(id, cancellationToken);
        }
    }
}
