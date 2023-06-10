using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
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
        private readonly ISellerRepository _sellerRepository;

        public GetStores(IStoreRepository storeRepository, ISellerRepository sellerRepository)
        {
            _storeRepository = storeRepository;
            _sellerRepository = sellerRepository;
        }
        public async Task<List<StoreDto>> Execute(CancellationToken cancellationToken)
        {
            var stores = await _storeRepository.GetAll(cancellationToken);
            foreach (var store in stores)
            {
                store.SellerName = (await _sellerRepository.GetById(store.Id, cancellationToken)).FirstName + " " +
                                        (await _sellerRepository.GetById(store.Id, cancellationToken)).LastName;
            }
            return stores;
        }
    }
}
