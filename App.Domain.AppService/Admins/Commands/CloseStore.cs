using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DataAccess;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class CloseStore : ICloseStore
    {
        private readonly IStoreRepository _storeRepository;

        public CloseStore(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task Execute(int StoreId, CancellationToken cancellationToken)
        {
            await _storeRepository.Close(StoreId, cancellationToken);
        }
    }
}
