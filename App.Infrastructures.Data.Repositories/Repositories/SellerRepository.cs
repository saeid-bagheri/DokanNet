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
    public class SellerRepository : ISellerRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public SellerRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task Create(SellerDto entity, CancellationToken cancellationToken)
        {
            var record = new Seller()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Mobile = entity.Mobile,
                Address = entity.Address,
                CityId = entity.CityId,
                IsDeleted = entity.IsDeleted,
                CreatedAt = entity.CreatedAt
            };
            await _context.Sellers.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<SellerDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Sellers
                .Where(s => s.IsDeleted == false).ToListAsync(cancellationToken);
            return _mapper.Map<List<SellerDto>>(records);
        }

        public async Task<SellerDto> GetById(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Sellers
                .Where(s => s.Id == id)
                .Include(s => s.City)
                .Include(s => s.Medal)
                .FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<SellerDto>(record);
        }

        public async Task Update(SellerDto entity, CancellationToken cancellationToken)
        {
            var record = await _context.Sellers
                .Where(s => s.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);

            record.FirstName = entity.FirstName;
            record.LastName = entity.LastName;
            record.Mobile = entity.Mobile;
            record.ShebaNumber = entity.ShebaNumber;
            record.CardNumber = entity.CardNumber;
            record.Address = entity.Address;
            record.CityId = entity.CityId;
            record.ProfileImgUrl = entity.ProfileImgUrl;
            record.Biography = entity.Biography;
            record.MedalId = entity.MedalId;
            record.Birthday = entity.Birthday;

            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Sellers
                .Where(s => s.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
