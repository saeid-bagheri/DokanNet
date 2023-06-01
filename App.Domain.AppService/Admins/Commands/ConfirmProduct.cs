using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Admins.Commands
{
    public class ConfirmProduct : IConfirmProduct
    {
        private readonly IProductRepository _productRepository;

        public ConfirmProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Execute(int productId, CancellationToken cancellationToken)
        {
            await _productRepository.ConfirmByAdmin(productId, cancellationToken);
        }
    }
}
