using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Admins.Queries
{
    public interface IGetInvoices
    {
        Task<List<InvoiceDto>> Execute(CancellationToken cancellationToken);
    }
}
