using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Data.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(UserManager<AppUser> userManager,
                              AppDbContext context,
                              IMapper mapper)
        {
            _userManager = userManager;
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> GetAll(CancellationToken cancellationToken)
        {
            var records = await _context.Users
                .Where(u => u.IsDeleted == false)
                .Select(u => new UserDto()
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    Email = u.Email,
                    CreatedAt = u.CreatedAt,
                    PhoneNumber = u.PhoneNumber
                }).ToListAsync(cancellationToken);
            ////check records is null
            //if (true)
            //{

            //}
            return records;
        }

        public async Task<UserDto> GetById(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Users
                .Where(u => u.Id == id).FirstOrDefaultAsync(cancellationToken);
            return _mapper.Map<UserDto>(record);
        }

        public async Task<List<string>> GetRolesByUserName(string userName, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user is not null)
            {
                var roles = await _userManager.GetRolesAsync(user);
                return roles.ToList();
            }
            return new List<string>();
        }

        public async Task Update(UserDto entity, CancellationToken cancellationToken)
        {
            var record = await _context.Users
                .Where(u => u.Id == entity.Id).FirstOrDefaultAsync(cancellationToken);
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var record = await _context.Users
                .Where(u => u.Id == id).FirstOrDefaultAsync(cancellationToken);
            record.IsDeleted = true;
            record.DeletedAt = DateTime.Now;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
