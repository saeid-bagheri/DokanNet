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
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly AppDbContext _context;

        public InvoiceRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<int> Create(InvoiceDto entity, CancellationToken cancellationToken)
        {
            var record = new Invoice
            {
                TotalAmount = entity.TotalAmount,
                SiteCommission = entity.SiteCommission,
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                IsFinal = entity.IsFinal,
                CreatedAt = entity.CreatedAt,
                InvoiceProducts = entity.InvoiceProducts
            };
            await _context.Invoices.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
            return record.Id;
        }

        public async Task<List<InvoiceDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<InvoiceDto>();
            records = await _context.Invoices
                .Where(i => i.IsFinal == true)
                .Include(i => i.Buyer)
                .Include(i => i.Seller)
                .Select(i => new InvoiceDto
                {
                    Id = i.Id,
                    TotalAmount = i.TotalAmount,
                    SiteCommission = i.SiteCommission,
                    BuyerId = i.BuyerId,
                    BuyerName = i.Buyer.FirstName + " " + i.Buyer.LastName,
                    SellerId = i.SellerId,
                    SellerName = i.Seller.FirstName + " " + i.Seller.LastName,
                    IsFinal = i.IsFinal,
                    CreatedAt = i.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<InvoiceDto>> GetAllBySellerId(int sellerId, CancellationToken cancellationToken)
        {
            var records = new List<InvoiceDto>();
            records = await _context.Invoices
                .Where(i => i.SellerId == sellerId)
                .Select(i => new InvoiceDto
                {
                    Id = i.Id,
                    TotalAmount = i.TotalAmount,
                    SiteCommission = i.SiteCommission,
                    BuyerId = i.BuyerId,
                    SellerId = i.SellerId,
                    IsFinal = i.IsFinal,
                    CreatedAt = i.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<InvoiceDto>> GetAllByBuyerId(int buyerId, CancellationToken cancellationToken)
        {
            var records = new List<InvoiceDto>();
            records = await _context.Invoices
                .Where(i => i.BuyerId == buyerId)
                .Select(i => new InvoiceDto
                {
                    Id = i.Id,
                    TotalAmount = i.TotalAmount,
                    SiteCommission = i.SiteCommission,
                    BuyerId = i.BuyerId,
                    SellerId = i.SellerId,
                    IsFinal = i.IsFinal,
                    CreatedAt = i.CreatedAt
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<InvoiceDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Invoices
                .Where(i => i.Id == id).FirstOrDefaultAsync(cancellationToken);
            var record = new InvoiceDto
            {
                Id = entity.Id,
                TotalAmount = entity.TotalAmount,
                SiteCommission = entity.SiteCommission,
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                IsFinal = entity.IsFinal,
                CreatedAt = entity.CreatedAt
            };
            return record;
        }

        public async Task Update(InvoiceDto entity, CancellationToken cancellationToken)
        {
            var Invoice = await _context.Invoices
                .Where(i => i.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            Invoice.TotalAmount = entity.TotalAmount;
            Invoice.SiteCommission = entity.SiteCommission;
            Invoice.BuyerId = entity.BuyerId;
            Invoice.SellerId = entity.SellerId;
            Invoice.IsFinal = entity.IsFinal;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
