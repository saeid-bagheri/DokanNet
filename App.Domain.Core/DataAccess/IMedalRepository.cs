using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IMedalRepository
    {
        Task Create(MedalDto entity, CancellationToken cancellationToken);
        Task<List<MedalDto>> GetAll(CancellationToken cancellationToken);
        Task<MedalDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(MedalDto entity, CancellationToken cancellationToken);
    }
}