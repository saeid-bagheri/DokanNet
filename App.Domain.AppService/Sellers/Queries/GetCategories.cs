using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Queries
{
    public class GetCategories : IGetCategories
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategories(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryDto>> Execute(CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAll(cancellationToken);
        }
    }
}
