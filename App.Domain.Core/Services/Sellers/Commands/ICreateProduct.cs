using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DtoModels;

namespace App.Domain.Core.AppServices.Sellers.Commands
{
    public interface ICreateProduct
    {
        Task<int> Execute(ProductDto entity, CancellationToken cancellationToken);
    }
}
