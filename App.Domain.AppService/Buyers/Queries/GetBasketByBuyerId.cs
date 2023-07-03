using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetBasketByBuyerId : IGetBasketByBuyerId
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetBasketByBuyerId(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<InvoiceDto> Execute(int buyerId, CancellationToken cancellationToken)
        {
            var basket = (await _invoiceRepository.GetAllByBuyerId(buyerId, cancellationToken))
                .Where(i => !i.IsFinal).FirstOrDefault();
            return basket;
        }
    }
}
