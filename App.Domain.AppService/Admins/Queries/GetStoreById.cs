using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Queries
{
    public class GetStoreById : IGetStoreById
    {
        private readonly IStoreRepository _storeRepository;
        private readonly ISellerRepository _sellerRepository;

        public GetStoreById(IStoreRepository storeRepository, ISellerRepository sellerRepository)
        {
            _storeRepository = storeRepository;
            _sellerRepository = sellerRepository;
        }

        public async Task<StoreDto> Execute(int id, CancellationToken cancellationToken)
        {
            var store = await _storeRepository.GetById(id, cancellationToken);
            store.SellerName = (await _sellerRepository.GetById(store.Id, cancellationToken)).FirstName + " " +
                                        (await _sellerRepository.GetById(store.Id, cancellationToken)).LastName;
            return store;
        }
    }
}
