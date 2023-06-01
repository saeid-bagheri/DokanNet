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
    public class ImageRepository : IImageRepository
    {
        private readonly AppDbContext _context;

        public ImageRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(ImageDto entity, CancellationToken cancellationToken)
        {
            var record = new Image
            {
                Title = entity.Title,
                Url = entity.Url,
                ProductId = entity.ProductId,
                IsDeleted = entity.IsDeleted,
                DeletedAt = entity.DeletedAt,
                CreatedAt = entity.CreatedAt
            };
            await _context.Images.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<ImageDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<ImageDto>();
            records = await _context.Images
                .Where(i => i.IsDeleted == false)
                .Select(i => new ImageDto
                {
                    Title = i.Title,
                    Url = i.Url,
                    ProductId = i.ProductId,
                    IsDeleted = i.IsDeleted,
                    DeletedAt = i.DeletedAt,
                    CreatedAt = i.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<ImageDto>> GetAllByProductId(int productId, CancellationToken cancellationToken)
        {
            var records = new List<ImageDto>();
            records = await _context.Images
                .Where(i => i.ProductId == productId && i.IsDeleted == false)
                .Select(i => new ImageDto
                {
                    Title = i.Title,
                    Url = i.Url,
                    ProductId = i.ProductId,
                    IsDeleted = i.IsDeleted,
                    DeletedAt = i.DeletedAt,
                    CreatedAt = i.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<ImageDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Images
                .Where(i => i.Id == id).FirstOrDefaultAsync(cancellationToken);
            var record = new ImageDto
            {
                Title = entity.Title,
                Url = entity.Url,
                ProductId = entity.ProductId,
                IsDeleted = entity.IsDeleted,
                DeletedAt = entity.DeletedAt,
                CreatedAt = entity.CreatedAt
            };
            return record;
        }

        public async Task Update(ImageDto entity, CancellationToken cancellationToken)
        {
            var Image = await _context.Images
                .Where(i => i.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            Image.Title = entity.Title;
            Image.Url = entity.Url;
            Image.ProductId = entity.ProductId;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Images
                .Where(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
