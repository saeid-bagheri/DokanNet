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
    public class BuyerRepository : IBuyerRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public BuyerRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task Create(BuyerDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Buyer>(entity);
            await _context.Buyers.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<BuyerDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Buyers
                .Where(b => b.IsDeleted == false).ToListAsync(cancellationToken);
            return _mapper.Map<List<BuyerDto>>(records);
        }

        public async Task<BuyerDto> GetById(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Buyers
                .Where(b => b.Id == id).FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<BuyerDto>(record);
        }

        public async Task Update(BuyerDto entity, CancellationToken cancellationToken)
        {
            var record = await _context.Buyers
                .Where(b => b.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Buyers
                .Where(b => b.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
