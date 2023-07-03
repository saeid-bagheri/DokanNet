using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetCountOfBasketProductsByBuyerId : IGetCountOfBasketProductsByBuyerId
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetCountOfBasketProductsByBuyerId(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<int> Execute(int buyerId, CancellationToken cancellationToken)
        {
            var basket = (await _invoiceRepository.GetAllByBuyerId(buyerId, cancellationToken))
                .Where(i => !i.IsFinal).FirstOrDefault();

            var count = 0;
            if (basket is not null)
            {
                foreach (var item in basket.InvoiceProducts)
                {
                    count += item.CountOfProducts;
                }
            }

            return count;
        }
    }
}
