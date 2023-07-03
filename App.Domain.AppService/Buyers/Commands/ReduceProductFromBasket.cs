using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Commands
{
    public class ReduceProductFromBasket : IReduceProductFromBasket
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IProductRepository _productRepository;

        public ReduceProductFromBasket(IInvoiceRepository invoiceRepository, IProductRepository productRepository)
        {
            _invoiceRepository = invoiceRepository;
            _productRepository = productRepository;
        }

        public async Task Execute(BasketProductDto entity, CancellationToken cancellationToken)
        {
            var currentBasket = (await _invoiceRepository.GetAllByBuyerId(entity.BuyerId, cancellationToken))
                .Where(i => !i.IsFinal).SingleOrDefault();


            //update total amount of invoice
            currentBasket.TotalAmount -= entity.CountOfProducts * (await _productRepository.GetById(entity.ProductId, cancellationToken)).Price;


            foreach (var item in currentBasket.InvoiceProducts)
            {
                if (item.ProductId == entity.ProductId)
                {
                    //update count of product
                    var invoiceProduct = currentBasket.InvoiceProducts
                        .Where(ip => ip.ProductId == entity.ProductId).SingleOrDefault();
                    invoiceProduct.CountOfProducts -= entity.CountOfProducts;

                    if (invoiceProduct.CountOfProducts == 0)
                    {
                        currentBasket.InvoiceProducts.Remove(item);
                        break;
                    }

                }
            }
            //update invoice
            if (currentBasket.InvoiceProducts.Count == 0)
            {
                await _invoiceRepository.Delete(currentBasket.Id, cancellationToken);
            }
            await _invoiceRepository.Update(currentBasket, cancellationToken);
            return;

        }
    }
}
