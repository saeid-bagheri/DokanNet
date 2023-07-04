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
    public class GetInvoicesByBuyerId : IGetInvoicesByBuyerId
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetInvoicesByBuyerId(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<List<InvoiceDto>> Execute(int buyerId, CancellationToken cancellationToken)
        {
            return (await _invoiceRepository.GetAllByBuyerId(buyerId, cancellationToken)).Where(i => i.IsFinal).ToList();
        }
    }
}
