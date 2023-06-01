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
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _context;

        public CityRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(CityDto entity, CancellationToken cancellationToken)
        {
            var record = new City
            {
                Title = entity.Title
            };
            await _context.Cities.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<CityDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<CityDto>();
            records = await _context.Cities
                .Select(c => new CityDto
                {
                    Id = c.Id,
                    Title = c.Title,
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<CityDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Cities
                .Where(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
            var record = new CityDto
            {
                Id = entity.Id,
                Title = entity.Title
            };
            return record;
        }

        public async Task Update(CityDto entity, CancellationToken cancellationToken)
        {
            var City = await _context.Cities
                .Where(c => c.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            City.Title = entity.Title;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
