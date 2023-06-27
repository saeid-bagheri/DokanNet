using App.Domain.Core.Configs;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Common.Commands
{
    public class CreateInvoice : ICreateInvoice
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly MedalConfig _medialConfig;
        private readonly ISellerRepository _sellerRepository;
        private readonly IInvoiceProductRepository _invoiceProductRepository;
        private readonly IUpdateMedal _updateMedal;

        public CreateInvoice(IInvoiceRepository invoiceRepository, MedalConfig medialConfig,
                             ISellerRepository sellerRepository, IInvoiceProductRepository invoiceProductRepository,
                             IUpdateMedal updateMedal)
        {
            _invoiceRepository = invoiceRepository;
            _medialConfig = medialConfig;
            _sellerRepository = sellerRepository;
            _invoiceProductRepository = invoiceProductRepository;
            _updateMedal = updateMedal;
        }
        public async Task Execute(InvoiceDto entity, CancellationToken cancellationToken)
        {

            var invoice = new InvoiceDto()
            {
                TotalAmount = entity.TotalAmount,
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                IsFinal = true,
                CreatedAt = DateTime.Now
            };

            //site commission calculation
            var feePercentage = 0;
            var seller = await _sellerRepository.GetById(entity.SellerId, cancellationToken);
            if (seller != null)
            {
                switch (seller.MedalId)
                {
                    case 1:
                        feePercentage = _medialConfig.FeePercentageGold;
                        break;
                    case 2:
                        feePercentage = _medialConfig.FeePercentageSilver;
                        break;
                    case 3:
                        feePercentage = _medialConfig.FeePercentageBronze;
                        break;
                    default:
                        feePercentage = _medialConfig.FeePercentageDefault;
                        break;
                }
            }
            invoice.SiteCommission = Convert.ToInt32(invoice.TotalAmount * (feePercentage / 100));
            var invoiceId = await _invoiceRepository.Create(invoice, cancellationToken);

            var invoiceProduct = new InvoiceProductDto()
            {
                InvoiceId = invoiceId,
                ProductId = entity.ProductId,
                CountOfProducts = entity.CountOfProducts
            };
            await _invoiceProductRepository.Create(invoiceProduct, cancellationToken);


            //update seller medal
            await _updateMedal.Execute(entity.SellerId, cancellationToken);

        }
    }
}
