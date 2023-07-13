using App.Domain.Core.DtoModels;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Buyers.Queries
{
    public interface IGetBuyerById
    {
        Task<BuyerDto> Execute(int id, CancellationToken cancellationToken);
    }
}
