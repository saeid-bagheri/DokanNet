using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Admins.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Admins.Queries
{
    public class GetInvoices : IGetInvoices
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public GetInvoices(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public async Task<List<InvoiceDto>> Execute(CancellationToken cancellationToken)
        {
            return await _invoiceRepository.GetAll(cancellationToken);
        }
    }
}
