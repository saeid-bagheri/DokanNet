using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetCategoryById : IGetCategoryById
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoryById(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDto> Execute(int categoryId, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetById(categoryId, cancellationToken);
        }
    }
}
