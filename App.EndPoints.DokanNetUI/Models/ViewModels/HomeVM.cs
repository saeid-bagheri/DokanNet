using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace App.EndPoints.DokanNetUI.Models.ViewModels
{
    public class HomeVM
    {
        public virtual List<BuyerAuctionVM> OpenAuctions { get; set; } = new List<BuyerAuctionVM>();
        public virtual List<BuyerProductVM> NormalProducts { get; set; } = new List<BuyerProductVM>();
    }
}