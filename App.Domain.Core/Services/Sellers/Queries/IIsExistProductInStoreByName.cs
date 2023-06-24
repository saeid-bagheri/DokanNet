using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Queries
{
    public interface IIsExistProductInStoreByName
    {
        Task<bool> Execute(string productName, int storeId, CancellationToken cancellationToken);
    }
}
