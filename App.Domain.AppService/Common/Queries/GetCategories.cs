using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Application.Queries
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
            var categories = await _categoryRepository.GetAll(cancellationToken);
            foreach (var item in categories)
            {
                if (item.ParentId is not null)
                {
                    item.ParentTitle = (await _categoryRepository.GetById(item.ParentId, cancellationToken)).Title;
                }
            }
            return categories;
        }
    }
}
