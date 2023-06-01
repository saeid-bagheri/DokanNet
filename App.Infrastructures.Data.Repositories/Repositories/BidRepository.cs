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
    public class BidRepository : IBidRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public BidRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task Create(BidDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Bid>(entity);
            await _context.Bids.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<BidDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Bids.ToListAsync(cancellationToken);
            return _mapper.Map<List<BidDto>>(records);
        }

        public async Task<List<BidDto>> GetAllByBuyerId(int BuyerId, CancellationToken cancellationToken)
        {
            var records = await _context.Bids
                .Where(b => b.BuyerId == BuyerId).ToListAsync(cancellationToken);
            return _mapper.Map<List<BidDto>>(records);
        }

        public async Task<BidDto> GetById(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Bids
                .Where(b => b.Id == id).FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<BidDto>(record);
        }
    }
}
