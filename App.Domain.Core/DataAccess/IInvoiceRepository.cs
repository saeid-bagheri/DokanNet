using App.Domain.Core.DtoModels;

namespace App.Infrastructures.Data.Repositories
{
    public interface IInvoiceRepository
    {
        Task<int> Create(InvoiceDto entity, CancellationToken cancellationToken);
        Task<List<InvoiceDto>> GetAll(CancellationToken cancellationToken);
        Task<List<InvoiceDto>> GetAllByBuyerId(int buyerId, CancellationToken cancellationToken);
        Task<List<InvoiceDto>> GetAllBySellerId(int sellerId, CancellationToken cancellationToken);
        Task<InvoiceDto> GetById(int id, CancellationToken cancellationToken);
        Task Update(InvoiceDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}