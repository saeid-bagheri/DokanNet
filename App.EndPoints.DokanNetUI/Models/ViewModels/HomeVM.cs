using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class HomeVM
    {
        public virtual List<AuctionDto> openAuctions { get; set; } = new List<AuctionDto>();
    }
}