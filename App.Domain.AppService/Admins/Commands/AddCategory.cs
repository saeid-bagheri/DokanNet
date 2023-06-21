using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Admins.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Admins.Commands
{
    public class AddCategory : IAddCategory
    {
        private readonly ICategoryRepository _categoryRepository;

        public AddCategory(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task Execute(CategoryDto entity, CancellationToken cancellationToken)
        {
            await _categoryRepository.Create(entity, cancellationToken);
        }
    }
}
