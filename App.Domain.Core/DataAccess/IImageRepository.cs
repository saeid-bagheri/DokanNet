using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IImageRepository
    {
        Task Create(ImageDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
        Task<List<ImageDto>> GetAll(CancellationToken cancellationToken);
        Task<List<ImageDto>> GetAllByProductId(int productId, CancellationToken cancellationToken);
        Task<ImageDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(ImageDto entity, CancellationToken cancellationToken);
    }
}