using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Admins.Commands
{
    public interface ICreateSeller
    {
        Task Execute(SellerDto model, CancellationToken cancellationToken);
    }
}
