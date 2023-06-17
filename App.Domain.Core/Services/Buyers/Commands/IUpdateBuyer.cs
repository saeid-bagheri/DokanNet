using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Buyers.Commands
{
    public interface IUpdateBuyer
    {
        Task Execute(BuyerDto model, CancellationToken cancellationToken);
    }
}
