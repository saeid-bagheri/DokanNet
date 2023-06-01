using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface ISellerRepository
    {
        Task Create(SellerDto entity, CancellationToken cancellationToken);
        Task<List<SellerDto>> GetAll(CancellationToken cancellationToken);
        Task<SellerDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(SellerDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}