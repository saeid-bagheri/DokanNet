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
    public class GetProducts : IGetProducts
    {
        private readonly IProductRepository _productRepository;
        private readonly ISellerRepository _sellerRepository;

        public GetProducts(IProductRepository productRepository, ISellerRepository sellerRepository)
        {
            _productRepository = productRepository;
            _sellerRepository = sellerRepository;
        }

        public async Task<List<ProductDto>> Execute(CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAll(cancellationToken);
            foreach (var product in products)
            {
                product.SellerName = (await _sellerRepository.GetById(product.StoreId, cancellationToken)).FirstName + " " +
                                        (await _sellerRepository.GetById(product.StoreId, cancellationToken)).LastName;
            }
            return products;
        }
    }
}
