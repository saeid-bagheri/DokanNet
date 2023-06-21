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
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;


        public CategoryRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task Create(CategoryDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Category>(entity);
            await _context.Categories.AddAsync(record, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<CategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Categories
                .Where(c => c.IsDeleted == false).ToListAsync(cancellationToken);
            return _mapper.Map<List<CategoryDto>>(records);
        }

        public async Task<CategoryDto> GetById(int? id, CancellationToken cancellationToken)
        {
            var record = await _context.Categories
                .Where(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<CategoryDto>(record);
        }

        public async Task Update(CategoryDto entity, CancellationToken cancellationToken)
        {
            var record = await _context.Categories
                .Where(c => c.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Categories
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
