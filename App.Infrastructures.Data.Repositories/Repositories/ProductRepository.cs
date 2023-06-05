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
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(ProductDto entity, CancellationToken cancellationToken)
        {
            var record = new Product
            {
                Title = entity.Title,
                CategoryId = entity.CategoryId,
                StoreId = entity.StoreId,
                Stock = entity.Stock,
                IsConfirmed = entity.IsConfirmed,
                IsAuction = entity.IsAuction,
                IsEnabled = entity.IsEnabled,
                Price = entity.Price,
                IsDeleted = entity.IsDeleted,
                CreatedAt = entity.CreatedAt
            };
            await _context.Products.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<ProductDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<ProductDto>();
            records = await _context.Products
                .Where(P => P.IsDeleted == false)
                .Include(p => p.Category)
                .Include(p => p.Store)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    CategoryTitle = p.Category.Title,
                    StoreId = p.StoreId,
                    StoreTitle = p.Store.Title,
                    Stock = p.Stock,
                    IsConfirmed = p.IsConfirmed,
                    IsAuction = p.IsAuction,
                    IsEnabled = p.IsEnabled,
                    Price = p.Price,
                    IsDeleted = p.IsDeleted,
                    CreatedAt = p.CreatedAt
                })
                .ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<ProductDto>> GetAllByStoreId(int storeId, CancellationToken cancellationToken)
        {
            var records = new List<ProductDto>();
            records = await _context.Products
                .Where(p => p.StoreId == storeId && p.IsDeleted == false)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    CategoryId = p.CategoryId,
                    StoreId = p.StoreId,
                    Stock = p.Stock,
                    IsConfirmed = p.IsConfirmed,
                    IsAuction = p.IsAuction,
                    IsEnabled = p.IsEnabled,
                    Price = p.Price,
                    IsDeleted = p.IsDeleted,
                    CreatedAt = p.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<ProductDto>> GetAllByCategoryId(int categoryId, CancellationToken cancellationToken)
        {
            var records = await _context.Products
                .Where(p => p.CategoryId == categoryId && p.IsDeleted == false)
                .Select(p => new ProductDto
                {
                    Id = p.Id,
                    Title = p.Title,
                    CategoryId = p.CategoryId,
                    StoreId = p.StoreId,
                    Stock = p.Stock,
                    IsConfirmed = p.IsConfirmed,
                    IsAuction = p.IsAuction,
                    IsEnabled = p.IsEnabled,
                    Price = p.Price,
                    IsDeleted = p.IsDeleted,
                    CreatedAt = p.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<ProductDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Products
                .Where(p => p.Id == id)
                .Include(p => p.Category)
                .Include(p => p.Store)
                .FirstOrDefaultAsync(cancellationToken);
            var record = new ProductDto
            {
                Id = entity.Id,
                Title = entity.Title,
                CategoryTitle = entity.Category.Title,
                StoreId = entity.StoreId,
                Stock = entity.Stock,
                IsConfirmed = entity.IsConfirmed,
                IsAuction = entity.IsAuction,
                IsEnabled = entity.IsEnabled,
                Price = entity.Price,
                IsDeleted = entity.IsDeleted,
                CreatedAt = entity.CreatedAt
            };
            return record;
        }

        public async Task Update(ProductDto entity, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .Where(p => p.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            product.Title = entity.Title;
            product.Stock = entity.Stock;
            product.IsConfirmed = entity.IsConfirmed;
            product.IsAuction = entity.IsAuction;
            product.IsEnabled = entity.IsEnabled;
            product.Price = entity.Price;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Products
                .Where(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task ConfirmByAdmin(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Products
                .Where(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsConfirmed = true;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
