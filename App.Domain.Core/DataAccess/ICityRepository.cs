using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface ICityRepository
    {
        Task Create(CityDto entity, CancellationToken cancellationToken);
        Task<List<CityDto>> GetAll(CancellationToken cancellationToken);
        Task<CityDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(CityDto entity, CancellationToken cancellationToken);
    }
}