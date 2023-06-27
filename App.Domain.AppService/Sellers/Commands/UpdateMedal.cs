using App.Domain.Core.Configs;
using App.Domain.Core.Services.Sellers.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Sellers.Commands
{
    public class UpdateMedal : IUpdateMedal
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly MedalConfig _medalConfig;

        public UpdateMedal(ISellerRepository sellerRepository, IInvoiceRepository invoiceRepository,
                           MedalConfig medalConfig)
        {
            _sellerRepository = sellerRepository;
            _invoiceRepository = invoiceRepository;
            _medalConfig = medalConfig;
        }
        public async Task Execute(int sellerId, CancellationToken cancellationToken)
        {
            //calculate the seller's income
            var sellerIncome = 0;
            var invoices = await _invoiceRepository.GetAllBySellerId(sellerId, cancellationToken);
            foreach (var invoice in invoices)
            {
                sellerIncome += invoice.TotalAmount;
            }

            //get seller and awarding of medals
            var sellerDto = await _sellerRepository.GetById(sellerId, cancellationToken);
            if (sellerIncome >= _medalConfig.GoldPrice)
            {
                sellerDto.MedalId = 1;
            }
            else if (sellerIncome >= _medalConfig.SilverPrice)
            {
                sellerDto.MedalId = 2;
            }
            else if (sellerIncome >= _medalConfig.BronzePrice)
            {
                sellerDto.MedalId = 3;
            }
            else
            {
                sellerDto.MedalId = null;
            }
            await _sellerRepository.Update(sellerDto, cancellationToken);

        }
    }
}
