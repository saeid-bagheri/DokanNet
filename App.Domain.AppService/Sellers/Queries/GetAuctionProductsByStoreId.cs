using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class GetAuctionProductsByStoreId : IGetAuctionProductsByStoreId
    {
        private readonly IProductRepository _productRepository;

        public GetAuctionProductsByStoreId(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<ProductDto>> Execute(int storeId, CancellationToken cancellationToken)
        {
            var products = (await _productRepository.GetAllByStoreId(storeId, cancellationToken)).Where(p => p.IsAuction == true).ToList();
            return products;
        }
    }
}
