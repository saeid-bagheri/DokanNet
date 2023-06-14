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
    public class CreateStore : ICreateStore
    {
        private readonly IStoreRepository _storeRepository;

        public CreateStore(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task Execute(StoreDto model, CancellationToken cancellationToken)
        {
            model.IsClosed = false;
            model.CreatedAt = DateTime.Now;
            await _storeRepository.Create(model, cancellationToken);
        }
    }
}
