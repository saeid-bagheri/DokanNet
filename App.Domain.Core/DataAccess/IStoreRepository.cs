using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IStoreRepository
    {
        Task Close(int id, CancellationToken cancellationToken);
        Task Create(StoreDto entity, CancellationToken cancellationToken);
        Task<List<StoreDto>> GetAll(CancellationToken cancellationToken);
        Task<StoreDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(StoreDto entity, CancellationToken cancellationToken);
    }
}