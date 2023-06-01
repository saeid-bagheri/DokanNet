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
    public class MedalRepository : IMedalRepository
    {
        private readonly AppDbContext _context;

        public MedalRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task Create(MedalDto entity, CancellationToken cancellationToken)
        {
            var record = new Medal
            {
                Title = entity.Title
            };
            await _context.Medals.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<MedalDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = new List<MedalDto>();
            records = await _context.Medals
                .Select(m => new MedalDto
                {
                    Id = m.Id,
                    Title = m.Title,
                }).ToListAsync(cancellationToken);
            return records;
        }

        public async Task<MedalDto> GetById(int id, CancellationToken cancellationToken)
        {
            var entity = await _context.Medals
                .Where(m => m.Id == id).FirstOrDefaultAsync(cancellationToken);
            var record = new MedalDto
            {
                Id = entity.Id,
                Title = entity.Title,
            };
            return record;
        }

        public async Task Update(MedalDto entity, CancellationToken cancellationToken)
        {
            var Medal = await _context.Medals
                .Where(m => m.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            Medal.Title = entity.Title;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
