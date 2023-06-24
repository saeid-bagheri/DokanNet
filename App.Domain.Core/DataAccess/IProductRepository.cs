using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;

namespace App.Domain.Core.DataAccess
{
    public interface IProductRepository
    {
        Task<int> Create(ProductDto entity, CancellationToken cancellationToken);
        Task<ProductDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetAllByStoreId(int storeId, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetAllByCategoryId(int categoryId, CancellationToken cancellationToken);
        Task<List<ProductDto>> GetAll(CancellationToken cancellationToken);
        Task Update(ProductDto entity, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);


        Task ConfirmByAdmin(int id, CancellationToken cancellationToken);

    }
}
