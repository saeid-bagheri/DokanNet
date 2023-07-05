using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Sellers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Commands
{
    public class CreateStore : ICreateStore
    {
        private readonly IStoreRepository _storeRepository;

        public CreateStore(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        public async Task Execute(StoreDto entity, string webRootPath, CancellationToken cancellationToken)
        {         
            //add store image to wwwroot
            var filename = Guid.NewGuid().ToString().Replace("-", "") + "-" + entity.Image.FileName;
            var filePath = Path.Combine(webRootPath, @"img\stores", filename);

            using (var stream = File.Create(filePath))
            {
                entity.Image.CopyTo(stream);
            }


            //add image to dataBase
            var storeDto = new StoreDto()
            {
                Id = entity.Id,
                Title = entity.Title,
                IsClosed = false,
                ImageUrl = @"\img\stores\" + filename,
                CreatedAt = DateTime.Now
            };
            await _storeRepository.Create(storeDto, cancellationToken);
        }
    }
}
