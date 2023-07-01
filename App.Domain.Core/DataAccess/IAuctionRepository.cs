using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IAuctionRepository
    {
        Task<int> Create(AuctionDto entity, CancellationToken cancellationToken);
        Task<List<AuctionDto>> GetAll(CancellationToken cancellationToken);
        Task<List<AuctionDto>> GetAllByStoreId(int storeId, CancellationToken cancellationToken);
        Task<AuctionDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(AuctionDto entity, CancellationToken cancellationToken);
    }
}