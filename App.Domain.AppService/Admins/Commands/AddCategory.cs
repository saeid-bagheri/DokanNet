using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
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
        public async Task Execute(CategoryDto entity, string webRootPath, CancellationToken cancellationToken)
        {
            //add category image to wwwroot
            var filename = Guid.NewGuid().ToString().Replace("-", "") + "-" + entity.Image.FileName;
            var filePath = Path.Combine(webRootPath, @"img\categories", filename);

            using (var stream = File.Create(filePath))
            {
                entity.Image.CopyTo(stream);
            }


            //add image to dataBase
            var categoryDto = new CategoryDto()
            {
                ParentId = entity.ParentId,
                Title = entity.Title,
                ImageUrl = @"\img\categories\" + filename,
                CreatedAt = DateTime.Now
            };


            await _categoryRepository.Create(categoryDto, cancellationToken);
        }
    }
}
