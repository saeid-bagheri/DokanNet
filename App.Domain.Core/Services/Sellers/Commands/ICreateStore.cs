using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Commands
{
    public interface ICreateStore
    {
        Task Execute(StoreDto model, CancellationToken cancellationToken);
    }
}
