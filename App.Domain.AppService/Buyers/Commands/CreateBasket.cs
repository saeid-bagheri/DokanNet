using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Buyers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Commands
{
    public class CreateBasket : ICreateBasket
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IProductRepository _productRepository;

        public CreateBasket(IInvoiceRepository invoiceRepository, IProductRepository productRepository)
        {
            _invoiceRepository = invoiceRepository;
            _productRepository = productRepository;
        }

        public async Task Execute(BasketProductDto entity, CancellationToken cancellationToken)
        {
            var invoiceDto = new InvoiceDto()
            {
                TotalAmount = (await _productRepository.GetById(entity.ProductId, cancellationToken)).Price,
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                IsFinal = false,
                CreatedAt = DateTime.Now
            };

            //create invoiceProducts
            var invoiceProducts = new List<InvoiceProduct>();
            invoiceProducts.Add(new InvoiceProduct()
            {
                ProductId = entity.ProductId,
                CountOfProducts = entity.CountOfProducts
            });
            invoiceDto.InvoiceProducts = invoiceProducts;



            await _invoiceRepository.Create(invoiceDto, cancellationToken);
        }
    }
}
