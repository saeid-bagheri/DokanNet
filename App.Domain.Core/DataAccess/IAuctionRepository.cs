using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IAuctionRepository
    {
        Task Create(AuctionDto entity, CancellationToken cancellationToken);
        Task<List<AuctionDto>> GetAll(CancellationToken cancellationToken);
        Task<List<AuctionDto>> GetAllBySellerId(int sellerId, CancellationToken cancellationToken);
        Task<AuctionDto> GetById(int id, CancellationToken cancellationToken);
    }
}