using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Data.Repositories.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly AppDbContext _context;

        public StoreRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(StoreDto entity, CancellationToken cancellationToken)
        {
            var record = new Store
            {
                Id = entity.Id,
                Title = entity.Title,
                ImageUrl = entity.ImageUrl,
                IsClosed = entity.IsClosed,
                CreatedAt = entity.CreatedAt
            };
            await _context.Stores.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<StoreDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<StoreDto>();
            records = await _context.Stores
                .Where(s => s.IsClosed == false)
                .Select(s => new StoreDto
                {
                    Id = s.Id,
                    Title = s.Title,
                    ImageUrl = s.ImageUrl,
                    IsClosed = s.IsClosed,
                    ClosedAt = s.ClosedAt,
                    CreatedAt = s.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<StoreDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Stores
                .Where(s => s.Id == id).FirstOrDefaultAsync(cancellationToken);
            var record = new StoreDto
            {
                Id = entity.Id,
                Title = entity.Title,
                ImageUrl = entity.ImageUrl,
                IsClosed = entity.IsClosed,
                ClosedAt = entity.ClosedAt,
                CreatedAt = entity.CreatedAt
            };
            return record;
        }

        public async Task Update(StoreDto entity, CancellationToken cancellationToken)
        {
            var Store = await _context.Stores
                .Where(s => s.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            Store.Title = entity.Title;
            Store.ImageUrl = entity.ImageUrl;
            Store.IsClosed = entity.IsClosed;
            Store.ClosedAt = entity.ClosedAt;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Close(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Stores
                .Where(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsClosed = true;
            record.ClosedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
