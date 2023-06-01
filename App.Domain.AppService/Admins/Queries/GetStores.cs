using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Queries
{
    public class GetStores : IGetStores
    {
        private readonly IStoreRepository _storeRepository;

        public GetStores(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task<List<StoreDto>> Execute(CancellationToken cancellationToken)
        {
            return await _storeRepository.GetAll(cancellationToken);
        }
    }
}
