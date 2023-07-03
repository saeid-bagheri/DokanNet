using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Commands;
using App.Domain.Core.Services.Common.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Commands
{
    public class FinalizePurchase : IFinalizePurchase
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly ICalculateSiteCommissionPercent _calculateSiteCommissionPercent;

        public FinalizePurchase(IInvoiceRepository invoiceRepository, ICalculateSiteCommissionPercent calculateSiteCommissionPercent)
        {
            _invoiceRepository = invoiceRepository;
            _calculateSiteCommissionPercent = calculateSiteCommissionPercent;
        }

        public async Task Execute(InvoiceDto entity, CancellationToken cancellationToken)
        {
            var invoiceDto = new InvoiceDto()
            {
                Id = entity.Id,
                TotalAmount = entity.TotalAmount,
                //site commission calculation
                SiteCommission = Convert.ToInt32(entity.TotalAmount * (await _calculateSiteCommissionPercent.Execute(entity.SellerId, cancellationToken))),
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                InvoiceProducts = entity.InvoiceProducts,
                IsFinal = true,
                CreatedAt = DateTime.Now,
            };
            await _invoiceRepository.Update(invoiceDto, cancellationToken);
        }
    }
}
