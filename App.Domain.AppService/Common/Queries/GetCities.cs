using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Application.Queries
{
    public class GetCities : IGetCities
    {
        private readonly ICityRepository _cityRepository;

        public GetCities(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public async Task<List<CityDto>> Execute(CancellationToken cancellationToken)
        {
            return await _cityRepository.GetAll(cancellationToken);
        }
    }
}
