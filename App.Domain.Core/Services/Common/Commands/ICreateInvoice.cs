using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Common.Commands
{
    public interface ICreateInvoice
    {
        Task Execute(InvoiceDto entity, CancellationToken cancellationToken);
    }
}
