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
using System.Threading;
using System.Threading.Tasks;

namespace App.Infrastructures.Data.Repositories.Repositories
{
    public class AuctionRepository : IAuctionRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public AuctionRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<int> Create(AuctionDto entity, CancellationToken cancellationToken)
        {

            var record = new Auction
            {
                StoreId = entity.StoreId,
                ProductId = entity.ProductId,
                CountOfProducts = entity.CountOfProducts,
                Price = entity.Price,
                HasBuyer = entity.HasBuyer,
                StartTime = entity.StartTime,
                EndTime = entity.EndTime,
                CreatedAt = entity.CreatedAt
            };
            await _context.Auctions.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return record.Id;
        }



        public async Task<List<AuctionDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Auctions
                .Include(a => a.Product)
                .ThenInclude(p => p.Images)
                .ToListAsync(cancellationToken);
            return _mapper.Map<List<AuctionDto>>(records);
        }

        public async Task<List<AuctionDto>> GetAllByStoreId(int storeId, CancellationToken cancellationToken)
        {
            var records = await _context.Auctions
                .Where(a => a.StoreId == storeId)
                .Include(a => a.Product)
                .ThenInclude(p => p.Images)
                .ToListAsync(cancellationToken);
            return _mapper.Map<List<AuctionDto>>(records);
        }

        public async Task<AuctionDto> GetById(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Auctions
                .Where(a => a.Id == id)
                .Include(a => a.Bids)
                .FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<AuctionDto>(record);
        }
        public async Task Update(AuctionDto entity, CancellationToken cancellationToken)
        {
            var auction = await _context.Auctions
                .Where(a => a.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            auction.HasBuyer = entity.HasBuyer;
            auction.Price = entity.Price;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
