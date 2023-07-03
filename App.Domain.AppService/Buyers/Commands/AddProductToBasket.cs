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
    public class AddProductToBasket : IAddProductToBasket
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IProductRepository _productRepository;

        public AddProductToBasket(IInvoiceRepository invoiceRepository, IProductRepository productRepository)
        {
            _invoiceRepository = invoiceRepository;
            _productRepository = productRepository;
        }

        public async Task Execute(InvoiceDto currentBasket, BasketProductDto entity, CancellationToken cancellationToken)
        {
            //update total amount of invoice
            currentBasket.TotalAmount += entity.CountOfProducts * (await _productRepository.GetById(entity.ProductId, cancellationToken)).Price;


            foreach (var item in currentBasket.InvoiceProducts)
            {
                //this product is already in the basket
                if (item.ProductId == entity.ProductId)
                {
                    //update count of product
                    var invoiceProduct = currentBasket.InvoiceProducts
                        .Where(ip => ip.ProductId == entity.ProductId).SingleOrDefault();
                    invoiceProduct.CountOfProducts += entity.CountOfProducts;

                    //update invoice
                    await _invoiceRepository.Update(currentBasket, cancellationToken);
                    return;
                }
            }

            //this product is not in the basket
            currentBasket.InvoiceProducts.Add(new InvoiceProduct()
            {
                ProductId = entity.ProductId,
                CountOfProducts = entity.CountOfProducts
            });

            //update invoice
            await _invoiceRepository.Update(currentBasket, cancellationToken);
            return;




        }
    }
}
