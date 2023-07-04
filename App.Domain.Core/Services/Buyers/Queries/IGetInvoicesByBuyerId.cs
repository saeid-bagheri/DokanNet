using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Buyers.Queries
{
    public interface IGetInvoicesByBuyerId
    {
        Task<List<InvoiceDto>> Execute(int buyerId, CancellationToken cancellationToken);
    }
}
