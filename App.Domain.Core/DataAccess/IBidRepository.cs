using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IBidRepository
    {
        Task Create(BidDto entity, CancellationToken cancellationToken);
        Task<List<BidDto>> GetAll(CancellationToken cancellationToken);
        Task<List<BidDto>> GetAllByAuctionId(int auctionId, CancellationToken cancellationToken);
        Task<List<BidDto>> GetAllByBuyerId(int buyerId, CancellationToken cancellationToken);
        Task<BidDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(BidDto entity, CancellationToken cancellationToken);
    }
}