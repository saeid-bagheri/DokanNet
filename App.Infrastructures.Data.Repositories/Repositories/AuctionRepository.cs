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


        public async Task Create(AuctionDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Auction>(entity);
            await _context.Auctions.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<AuctionDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Auctions.ToListAsync(cancellationToken);
            return _mapper.Map<List<AuctionDto>>(records);
        }

        public async Task<List<AuctionDto>> GetAllBySellerId(int sellerId, CancellationToken cancellationToken)
        {
            var records = await _context.Auctions
                .Where(a => a.SellerId == sellerId).ToListAsync(cancellationToken);
            return _mapper.Map<List<AuctionDto>>(records);
        }

        public async Task<AuctionDto> GetById(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Auctions
                .Where(a => a.Id == id).FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<AuctionDto>(record);
        }
    }
}
