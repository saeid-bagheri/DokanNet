using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Data.Repositories.Repositories
{
    public class InvoiceProductRepository : IInvoiceProductRepository
    {
        private readonly AppDbContext _context;

        public InvoiceProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(InvoiceProductDto entity, CancellationToken cancellationToken)
        {
            var record = new InvoiceProduct
            {
                InvoiceId = entity.InvoiceId,
                ProductId = entity.ProductId,
                CountOfProducts = entity.CountOfProducts
            };
            await _context.InvoiceProducts.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
