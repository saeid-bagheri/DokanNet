using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class GetSellerByProductId : IGetSellerByProductId
    {
        private readonly IProductRepository _productRepository;
        private readonly ISellerRepository _sellerRepository;

        public GetSellerByProductId(IProductRepository productRepository, ISellerRepository sellerRepository)
        {
            _productRepository = productRepository;
            _sellerRepository = sellerRepository;
        }

        public async Task<SellerDto> Execute(int productId, CancellationToken cancellationToken)
        {
            //get product
            var productDto = await _productRepository.GetById(productId, cancellationToken);

            //get seller
            var sellerDto = await _sellerRepository.GetById(productDto.StoreId, cancellationToken);

            return sellerDto;

        }
    }
}
