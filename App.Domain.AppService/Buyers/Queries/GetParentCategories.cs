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
    public class GetParentCategories : IGetParentCategories
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetParentCategories(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDto>> Execute(CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetAll(cancellationToken);
            return categories.Where(c => c.ParentId is null).ToList();
        }
    }
}
