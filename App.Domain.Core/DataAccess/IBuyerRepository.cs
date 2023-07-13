using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IBuyerRepository
    {
        Task Create(BuyerDto entity, CancellationToken cancellationToken);
        Task<List<BuyerDto>> GetAll(CancellationToken cancellationToken);
        Task<BuyerDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(BuyerDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}