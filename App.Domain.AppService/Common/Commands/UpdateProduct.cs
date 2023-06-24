using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Common.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Common.Commands
{
    public class UpdateProduct : IUpdateProduct
    {
        private readonly IProductRepository _productRepository;

        public UpdateProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Execute(ProductDto entity, CancellationToken cancellationToken)
        {
            await _productRepository.Update(entity, cancellationToken);
        }
    }
}
