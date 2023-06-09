﻿using App.Domain.Core.Configs;
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
        private readonly IUpdateMedal _updateMedal;
        private readonly ICalculateSiteCommissionPercent _calculateSiteCommissionPercent;

        public CreateInvoice(IInvoiceRepository invoiceRepository, IUpdateMedal updateMedal,
                             ICalculateSiteCommissionPercent calculateSiteCommissionPercent)
        {
            _invoiceRepository = invoiceRepository;
            _updateMedal = updateMedal;
            _calculateSiteCommissionPercent = calculateSiteCommissionPercent;
        }
        public async Task Execute(InvoiceDto entity, CancellationToken cancellationToken)
        {

            var invoiceDto = new InvoiceDto()
            {
                TotalAmount = entity.TotalAmount,
                //site commission calculation
                SiteCommission = Convert.ToInt32(entity.TotalAmount * (await _calculateSiteCommissionPercent.Execute(entity.SellerId, cancellationToken))),
                BuyerId = entity.BuyerId,
                SellerId = entity.SellerId,
                InvoiceProducts = entity.InvoiceProducts,
                IsFinal = true,
                CreatedAt = DateTime.Now
            };

            //create invoice
            await _invoiceRepository.Create(invoiceDto, cancellationToken);

            //update seller medal
            await _updateMedal.Execute(entity.SellerId, cancellationToken);

        }
    }
}
