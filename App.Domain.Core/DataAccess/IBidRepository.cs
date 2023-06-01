using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IBidRepository
    {
        Task Create(BidDto entity, CancellationToken cancellationToken);
        Task<List<BidDto>> GetAll(CancellationToken cancellationToken);
        Task<List<BidDto>> GetAllByBuyerId(int BuyerId, CancellationToken cancellationToken);
        Task<BidDto> GetById(int id, CancellationToken cancellationToken);
    }
}