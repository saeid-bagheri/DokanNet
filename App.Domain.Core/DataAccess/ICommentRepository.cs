using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface ICommentRepository
    {
        Task Create(CommentDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAll(CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAllByBuyerId(int buyerId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAllByProductId(int productId, CancellationToken cancellationToken);
        Task<List<CommentDto>> GetAllNotConfirmed(CancellationToken cancellationToken);
        Task<CommentDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(CommentDto entity, CancellationToken cancellationToken);


        Task ConfirmByAdmin(int id, CancellationToken cancellationToken);
    }
}