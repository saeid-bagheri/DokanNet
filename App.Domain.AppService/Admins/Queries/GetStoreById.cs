using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Queries
{
    public class GetStoreById : IGetStoreById
    {
        private readonly IStoreRepository _storeRepository;

        public GetStoreById(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task<StoreDto> Execute(int id, CancellationToken cancellationToken)
        {
            return await _storeRepository.GetById(id, cancellationToken);
        }
    }
}
