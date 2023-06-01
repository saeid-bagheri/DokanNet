using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task Create(CategoryDto entity, CancellationToken cancellationToken);
        Task<List<CategoryDto>> GetAll(CancellationToken cancellationToken);
        Task<CategoryDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(CategoryDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}