using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Commands
{
    public interface IUpdateMedal
    {
        Task Execute(int sellerId, CancellationToken cancellationToken);
    }
}
