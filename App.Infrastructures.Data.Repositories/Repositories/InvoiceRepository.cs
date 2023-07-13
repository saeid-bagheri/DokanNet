using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public InvoiceRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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
                InvoiceProducts = _mapper.Map<List<InvoiceProduct>>(entity.InvoiceProducts)
            };
            await _context.Invoices.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
            return record.Id;
        }

        public async Task<List<InvoiceDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<InvoiceDto>();
            records = await _context.Invoices
                .Where(i => i.IsFinal == true && !i.IsDeleted)
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
                .Where(i => i.SellerId == sellerId && !i.IsDeleted)
                .Include(i => i.Buyer)
                .Include(i => i.InvoiceProducts)
                .ThenInclude(ip => ip.Product)
                .Select(i => new InvoiceDto
                {
                    Id = i.Id,
                    TotalAmount = i.TotalAmount,
                    SiteCommission = i.SiteCommission,
                    BuyerId = i.BuyerId,
                    SellerId = i.SellerId,
                    IsFinal = i.IsFinal,
                    CreatedAt = i.CreatedAt,
                    InvoiceProducts = _mapper.Map<List<InvoiceProductDto>>(i.InvoiceProducts),
                    Buyer = _mapper.Map<BuyerDto>(i.Buyer)
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<List<InvoiceDto>> GetAllByBuyerId(int buyerId, CancellationToken cancellationToken)
        {
            var records = new List<InvoiceDto>();
            records = await _context.Invoices
                .Where(i => i.BuyerId == buyerId && !i.IsDeleted)
                .Include(i => i.Seller)
                .Include(i => i.InvoiceProducts)
                .ThenInclude(ip => ip.Product)
                .Select(i => new InvoiceDto
                {
                    Id = i.Id,
                    TotalAmount = i.TotalAmount,
                    SiteCommission = i.SiteCommission,
                    BuyerId = i.BuyerId,
                    SellerId = i.SellerId,
                    IsFinal = i.IsFinal,
                    CreatedAt = i.CreatedAt,
                    InvoiceProducts = _mapper.Map<List<InvoiceProductDto>>(i.InvoiceProducts),
                    Seller = _mapper.Map<SellerDto>(i.Seller)
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

            var invoice = await _context.Invoices
                .Include(i => i.InvoiceProducts)
                .FirstOrDefaultAsync(i => i.Id == entity.Id, cancellationToken);

            if (invoice != null)
            {
                // به روزرسانی مقادیر مربوط به Invoice
                invoice.TotalAmount = entity.TotalAmount;
                invoice.SiteCommission = entity.SiteCommission;
                invoice.BuyerId = entity.BuyerId;
                invoice.SellerId = entity.SellerId;
                invoice.IsFinal = entity.IsFinal;

                // به روزرسانی InvoiceProducts
                var existingProductIds = invoice.InvoiceProducts.Select(ip => ip.ProductId).ToList();
                var updatedProductIds = entity.InvoiceProducts.Select(ip => ip.ProductId).ToList();

                // حذف InvoiceProducts غیرموجود
                var removedInvoiceProducts = invoice.InvoiceProducts.Where(ip => !updatedProductIds.Contains(ip.ProductId)).ToList();
                foreach (var removedInvoiceProduct in removedInvoiceProducts)
                {
                    invoice.InvoiceProducts.Remove(removedInvoiceProduct);
                }

                // اضافه کردن InvoiceProducts جدید
                var addedInvoiceProducts = entity.InvoiceProducts.Where(ip => !existingProductIds.Contains(ip.ProductId)).ToList();
                foreach (var addedInvoiceProductDto in addedInvoiceProducts)
                {
                    var addedInvoiceProduct = new InvoiceProduct
                    {
                        InvoiceId = invoice.Id,
                        ProductId = addedInvoiceProductDto.ProductId,
                        CountOfProducts = addedInvoiceProductDto.CountOfProducts
                    };
                    invoice.InvoiceProducts.Add(addedInvoiceProduct);
                }

                // به روزرسانی InvoiceProducts موجود
                foreach (var updatedInvoiceProductDto in entity.InvoiceProducts)
                {
                    var existingInvoiceProduct = invoice.InvoiceProducts.FirstOrDefault(ip => ip.ProductId == updatedInvoiceProductDto.ProductId);
                    if (existingInvoiceProduct != null)
                    {
                        existingInvoiceProduct.CountOfProducts = updatedInvoiceProductDto.CountOfProducts;
                    }
                }

                await _context.SaveChangesAsync(cancellationToken);
            }






            //var Invoice = await _context.Invoices
            //    .Where(i => i.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            //Invoice.TotalAmount = entity.TotalAmount;
            //Invoice.SiteCommission = entity.SiteCommission;
            //Invoice.BuyerId = entity.BuyerId;
            //Invoice.SellerId = entity.SellerId;
            //Invoice.IsFinal = entity.IsFinal;
            //Invoice.InvoiceProducts = entity.InvoiceProducts;
            //await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Invoices
                .Where(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }


    }
}
