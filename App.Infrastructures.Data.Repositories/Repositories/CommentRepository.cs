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
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;

        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(CommentDto entity, CancellationToken cancellationToken)
        {
            var record = new Comment
            {
                Description = entity.Description,
                Score = entity.Score,
                BuyerId = entity.BuyerId,
                ProductId = entity.ProductId,
                CreatedAt = entity.CreatedAt,
                IsConfirmed = entity.IsConfirmed,
                IsDeleted = entity.IsDeleted,
                DeletedAt = entity.DeletedAt
            };
            await _context.Comments.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<CommentDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<CommentDto>();
            records = await _context.Comments
                .Where(c => c.IsDeleted == false)
                .Include(c => c.Buyer)
                .Include(c => c.Product)
                .Select(c => new CommentDto
                {
                    Id = c.Id,
                    Description = c.Description,
                    Score = c.Score,
                    BuyerName = c.Buyer.FirstName + " " + c.Buyer.LastName,
                    ProductName = c.Product.Title,
                    CreatedAt = c.CreatedAt,
                    IsConfirmed = c.IsConfirmed,
                    IsDeleted = c.IsDeleted
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<CommentDto>> GetAllNotConfirmed(CancellationToken cancellationToken)
        {
            var records = new List<CommentDto>();
            records = await _context.Comments
                .Where(c => c.IsConfirmed == false && c.IsDeleted == false)
                .Select(c => new CommentDto
                {
                    Description = c.Description,
                    Score = c.Score,
                    BuyerId = c.BuyerId,
                    ProductId = c.ProductId,
                    CreatedAt = c.CreatedAt,
                    IsConfirmed = c.IsConfirmed,
                    IsDeleted = c.IsDeleted,
                    DeletedAt = c.DeletedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<CommentDto>> GetAllByBuyerId(int buyerId, CancellationToken cancellationToken)
        {
            var records = await _context.Comments
                .Where(c => c.BuyerId == buyerId && c.IsDeleted == false && c.IsConfirmed == true)
                .Select(c => new CommentDto
                {
                    Description = c.Description,
                    Score = c.Score,
                    BuyerId = c.BuyerId,
                    ProductId = c.ProductId,
                    CreatedAt = c.CreatedAt,
                    IsConfirmed = c.IsConfirmed,
                    IsDeleted = c.IsDeleted,
                    DeletedAt = c.DeletedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<CommentDto>> GetAllByProductId(int productId, CancellationToken cancellationToken)
        {
            var records = await _context.Comments
                .Where(c => c.ProductId == productId && c.IsDeleted == false && c.IsConfirmed == true)
                .Select(c => new CommentDto
                {
                    Description = c.Description,
                    Score = c.Score,
                    BuyerId = c.BuyerId,
                    ProductId = c.ProductId,
                    CreatedAt = c.CreatedAt,
                    IsConfirmed = c.IsConfirmed,
                    IsDeleted = c.IsDeleted,
                    DeletedAt = c.DeletedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<CommentDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Comments
                .Where(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
            var record = new CommentDto
            {
                Id = entity.Id,
                Description = entity.Description,
                Score = entity.Score,
                IsConfirmed = entity.IsConfirmed,
                IsDeleted = entity.IsDeleted,
                DeletedAt = entity.DeletedAt,
                BuyerId = entity.BuyerId,
                ProductId = entity.ProductId,
                CreatedAt = entity.CreatedAt
            };
            return record;
        }

        public async Task Update(CommentDto entity, CancellationToken cancellationToken)
        {
            var Comment = await _context.Comments
                .Where(c => c.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            Comment.Description = entity.Description;
            Comment.Score = entity.Score;
            Comment.IsConfirmed = entity.IsConfirmed;
            Comment.BuyerId = entity.BuyerId;
            Comment.ProductId = entity.ProductId;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Comments
                .Where(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task ConfirmByAdmin(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Comments
                .Where(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
            if (record is not null)
            {
                record.IsConfirmed = true;
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
