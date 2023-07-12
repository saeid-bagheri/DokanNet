using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Commands
{
    public class SellerUpdateProduct : ISellerUpdateProduct
    {
        private readonly IProductRepository _productRepository;

        public SellerUpdateProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Execute(ProductDto entity, CancellationToken cancellationToken)
        {
            entity.IsEnabled = true;
            await _productRepository.Update(entity, cancellationToken);
        }
    }
}
