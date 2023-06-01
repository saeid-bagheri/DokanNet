using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class UpdateStore : IUpdateStore
    {
        private readonly IStoreRepository _storeRepository;

        public UpdateStore(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task Execute(StoreDto entity, CancellationToken cancellationToken)
        {
            await _storeRepository.Update(entity, cancellationToken);
        }
    }
}
