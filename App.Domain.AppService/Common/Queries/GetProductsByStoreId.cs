using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Common.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Common.Queries
{
    public class GetProductsByStoreId : IGetProductsByStoreId
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GetProductsByStoreId(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<List<ProductDto>> Execute(int storeId, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllByStoreId(storeId, cancellationToken);
            foreach (var product in products)
            {
                product.CategoryTitle = (await _categoryRepository.GetById(product.CategoryId, cancellationToken)).Title;
            }
            return products;
        }
    }
}
