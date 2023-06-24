using App.Domain.Core.DataAccess;
using App.Domain.Core.Services.Sellers.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class IsExistProductInStoreByName : IIsExistProductInStoreByName
    {
        private readonly IProductRepository _productRepository;

        public IsExistProductInStoreByName(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> Execute(string productName, int storeId, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllByStoreId(storeId, cancellationToken);
            return products.Where(p => p.Title ==  productName).Any();
        }
    }
}
