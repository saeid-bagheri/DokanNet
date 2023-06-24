using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Commands
{
    public interface IReduceProductStock
    {
        Task Execute(int countOfProducts, int productId, CancellationToken cancellationToken);
    }
}
