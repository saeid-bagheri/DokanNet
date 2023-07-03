using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class BasketProductDto
    {
        public int ProductId { get; set; }
        public int CountOfProducts { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
    }
}
