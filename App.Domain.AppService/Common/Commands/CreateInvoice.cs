using App.Domain.Core.Configs;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App.Domain.Service.Common.Commands
{
    public class CreateInvoice : ICreateInvoice
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly MedalConfig _medialConfig;
        private readonly ISellerRepository _sellerRepository;
        private readonly IUpdateMedal _updateMedal;

        public CreateInvoice(IInvoiceRepository invoiceRepository, MedalConfig medialConfig,
                             ISellerRepository sellerRepository, IUpdateMedal updateMedal)
        {
            _invoiceRepository = invoiceRepository;
            _medialConfig = medialConfig;
            _sellerRepository = sellerRepository;
            _updateMedal = updateMedal;
        }
        public async Task Execute(InvoiceDto entity, CancellationToken cancellationToken)
        {

            var invoiceDto = new InvoiceDto()
            {
                TotalAmount = entity.TotalAmount,
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                Products = entity.Products,
                IsFinal = true,
                CreatedAt = DateTime.Now
            };

            //site commission calculation
            double feePercentage = 0;
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
            double percent = feePercentage / 100;
            invoiceDto.SiteCommission = Convert.ToInt32(invoiceDto.TotalAmount * percent);


            //invoiceProduct
            var invoiceProducts = new List<InvoiceProduct>();
            foreach (var product in invoiceDto.Products)
            {
                invoiceProducts.Add(new InvoiceProduct()
                {
                    ProductId = product.Id,
                    CountOfProducts = product.CountInInvoice
                });
            }
            invoiceDto.InvoiceProducts = invoiceProducts;


            //create invoice
            await _invoiceRepository.Create(invoiceDto, cancellationToken);



            //update seller medal
            await _updateMedal.Execute(entity.SellerId, cancellationToken);

        }
    }
}
