using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetProductsByCategoryAndSubcategories : IGetProductsByCategoryAndSubcategories
    {
        private readonly IProductRepository _productRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IStoreRepository _storeRepository;

        public GetProductsByCategoryAndSubcategories(IProductRepository productRepository, ISellerRepository sellerRepository,
                                                     IStoreRepository storeRepository)
        {
            _productRepository = productRepository;
            _sellerRepository = sellerRepository;
            _storeRepository = storeRepository;
        }

        public async Task<List<ProductDto>> Execute(int parentCategoryId, CancellationToken cancellationToken)
        {
            var products = (await _productRepository.GetAllByCategoryId(parentCategoryId, cancellationToken))
                            .Where(p => p.Category.ParentId is null).ToList();
            foreach (var product in products)
            {
                product.SellerName = (await _sellerRepository.GetById(product.StoreId, cancellationToken)).FirstName + " " +
                                      (await _sellerRepository.GetById(product.StoreId, cancellationToken)).LastName;
                product.StoreTitle = (await _storeRepository.GetById(product.StoreId, cancellationToken)).Title;
            }
            return products;
        }
    }
}