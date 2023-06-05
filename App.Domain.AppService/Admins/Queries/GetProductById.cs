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
    public class GetProductById : IGetProductById
    {
        private readonly IProductRepository _productRepository;
        private readonly ISellerRepository _sellerRepository;

        public GetProductById(IProductRepository productRepository, ISellerRepository sellerRepository)
        {
            _productRepository = productRepository;
            _sellerRepository = sellerRepository;
        }

        public async Task<ProductDto> Execute(int id, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(id, cancellationToken);
            product.SellerName = (await _sellerRepository.GetById(product.StoreId, cancellationToken)).FirstName + " " +
                                    (await _sellerRepository.GetById(product.StoreId, cancellationToken)).LastName;
            return product;
        }
    }
}
