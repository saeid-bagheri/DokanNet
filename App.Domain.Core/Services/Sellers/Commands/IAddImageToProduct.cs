using App.Domain.Core.DtoModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Services.Sellers.Commands
{
    public interface IAddImageToProduct
    {
        Task Execute(int productId, IFormFile entity, string filePath, CancellationToken cancellationToken);
    }
}
