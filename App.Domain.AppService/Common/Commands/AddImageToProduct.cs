using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Common.Commands;
using App.Infrastructures.Data.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Common.Commands
{
    public class AddImageToProduct : IAddImageToProduct
    {
        private readonly IImageRepository _imageRepository;

        public AddImageToProduct(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        public async Task Execute(int productId, IFormFile entity, string webRootPath, CancellationToken cancellationToken)
        {
            //add image to wwwroot
            var filename = Guid.NewGuid().ToString().Replace("-", "") + "-" + entity.FileName;
            var filePath = Path.Combine(webRootPath, "productImages", filename);

            using (var stream = File.Create(filePath))
            {
                entity.CopyTo(stream);
            }


            //add image to dataBase
            var imageDto = new ImageDto()
            {
                Title = filename,
                Url = @"\productImages\" + filename,
                ProductId = productId,
                CreatedAt = DateTime.Now
            };
            await _imageRepository.Create(imageDto, cancellationToken);
        }
    }
}
