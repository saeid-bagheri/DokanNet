using App.Domain.Core.AppServices.Sellers.Commands;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Domain.Service.Sellers.Commands
{
    public class CreateProduct : ICreateProduct
    {
        private readonly IProductRepository _productRepository;
        private readonly IImageRepository _imageRepository;

        public CreateProduct(IProductRepository productRepository, IImageRepository imageRepository)
        {
            _productRepository = productRepository;
            _imageRepository = imageRepository;
        }

        public async Task<int> Execute(ProductDto entity, CancellationToken cancellationToken)
        {
            var productDto = new ProductDto()
            {
                Title = entity.Title,
                CategoryId = entity.CategoryId,
                StoreId = entity.StoreId,
                Stock = entity.Stock,
                IsConfirmed = false,
                IsAuction = entity.IsAuction,
                IsEnabled = !entity.IsAuction,
                Price = entity.Price,
                CreatedAt = DateTime.Now
            };
            int productId = await _productRepository.Create(productDto, cancellationToken);
            return productId;
        }
    }
}
