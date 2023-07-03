using App.Domain.Core.Configs;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Common.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Common.Commands
{
    public class CalculateSiteCommissionPercent : ICalculateSiteCommissionPercent
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly MedalConfig _medialConfig;

        public CalculateSiteCommissionPercent(ISellerRepository sellerRepository, MedalConfig medialConfig)
        {
            _sellerRepository = sellerRepository;
            _medialConfig = medialConfig;
        }

        public async Task<double> Execute(int sellerId, CancellationToken cancellationToken)
        {
            double feePercentage = 0;
            var seller = await _sellerRepository.GetById(sellerId, cancellationToken);
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
            double siteCommissionPercent = feePercentage / 100;
            return siteCommissionPercent;
        }
    }
}
