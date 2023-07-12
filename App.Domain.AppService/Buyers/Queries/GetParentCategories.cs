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
            var categories = (await _categoryRepository.GetAll(cancellationToken))
                    .Where(c => c.ParentId is null).ToList();

            foreach (var category in categories)
            {
                await GetSubCategoriesRecursive(category, cancellationToken);
            }
            return categories;
        }



        private async Task GetSubCategoriesRecursive(CategoryDto category, CancellationToken cancellationToken)
        {
            //subCategories related to the same category
            category.SubCategories = (await _categoryRepository.GetAll(cancellationToken)).Where(c => c.ParentId == category.Id).ToList();

            foreach (var subCategory in category.SubCategories)
            {
                await GetSubCategoriesRecursive(subCategory, cancellationToken);
            }
        }



    }
}
