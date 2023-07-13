using App.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels
{
    public class MedalDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        #region navigations

        public virtual ICollection<SellerDto> Sellers { get; set; } = new List<SellerDto>();

        #endregion navigations
    }
}
