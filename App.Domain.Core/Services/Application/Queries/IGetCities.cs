using App.Domain.Core.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Application.Queries
{
    public interface IGetCities
    {
        Task<List<CityDto>> Execute(CancellationToken cancellationToken);
    }
}
