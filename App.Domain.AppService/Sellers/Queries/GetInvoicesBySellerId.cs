using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class GetInvoicesBySellerId : IGetInvoicesBySellerId
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetInvoicesBySellerId(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<List<InvoiceDto>> Execute(int sellerId, CancellationToken cancellationToken)
        {
            return (await _invoiceRepository.GetAllBySellerId(sellerId, cancellationToken)).Where(i => i.IsFinal).ToList();
        }
    }
}
