using App.Domain.Core.Services.Buyers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Commands
{
    public class UpdateBuyer : IUpdateBuyer
    {
        private readonly IBuyerRepository _buyerRepository;

        public UpdateBuyer(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }
        public async Task Execute(BuyerDto model, CancellationToken cancellationToken)
        {
            await _buyerRepository.Update(model, cancellationToken);
        }
    }
}
