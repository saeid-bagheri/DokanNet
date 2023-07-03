using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Common.Commands
{
    public interface IAddProductStock
    {
        Task Execute(int countOfProducts, int productId, CancellationToken cancellationToken);
    }
}
