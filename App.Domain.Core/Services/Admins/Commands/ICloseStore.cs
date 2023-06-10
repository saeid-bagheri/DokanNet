using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Admins.Commands
{
    public interface ICloseStore
    {
        Task Execute(int storeId, CancellationToken cancellationToken);
    }
}
