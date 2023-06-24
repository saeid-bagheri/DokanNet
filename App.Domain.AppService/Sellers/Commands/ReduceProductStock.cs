using App.Domain.Core.DataAccess;
using App.Domain.Core.Services.Sellers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Commands
{
    public class ReduceProductStock : IReduceProductStock
    {
        private readonly IProductRepository _productRepository;

        public ReduceProductStock(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task Execute(int countOfProducts, int productId, CancellationToken cancellationToken)
        {
            //get product
            var productDto = await _productRepository.GetById(productId, cancellationToken);
            if (productDto is not null)
            {
                productDto.Stock = productDto.Stock - countOfProducts;
                //update product
                await _productRepository.Update(productDto, cancellationToken);
            }
        }
    }
}
