using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Admins.Commands;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Admins.Commands
{
    public class EndOfAuction : IEndOfAuction
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IProductRepository _productRepository;
        private readonly IInvoiceProductRepository _invoiceProductRepository;

        public EndOfAuction(IAuctionRepository auctionRepository, ISellerRepository sellerRepository,
                            IInvoiceRepository invoiceRepository, IProductRepository productRepository,
                            IInvoiceProductRepository invoiceProductRepository)
        {
            _auctionRepository = auctionRepository;
            _sellerRepository = sellerRepository;
            _invoiceRepository = invoiceRepository;
            _productRepository = productRepository;
            _invoiceProductRepository = invoiceProductRepository;
        }



        public async Task Execute(int auctionId, CancellationToken cancellationToken)
        {
            //get auction
            var auction = await _auctionRepository.GetById(auctionId, cancellationToken);

            //check auction has buyer or not
            if (auction.HasBuyer)
            {
                //get winnerBid for find buyerId
                var winnerBid = auction.Bids.Where(b => b.IsWinner).FirstOrDefault();

                //get seller
                var seller = await _sellerRepository.GetById(auction.StoreId, cancellationToken);


                //create new invoice
                var invoice = new InvoiceDto()
                {
                    TotalAmount = auction.Price,
                    SiteCommission = Convert.ToInt32(auction.Price - ((seller.FeePercentage / 100) * auction.Price)),
                    BuyerId = winnerBid.BuyerId,
                    SellerId = seller.Id,
                    IsFinal = true,
                    CreatedAt = DateTime.Now
                };
                var invoiceId = await _invoiceRepository.Create(invoice, cancellationToken);

                //create new invoiceProduct
                var invoiceProduct = new InvoiceProductDto()
                {
                    InvoiceId = invoiceId,
                    ProductId = auction.ProductId,
                    CountOfProducts = auction.CountOfProducts
                };
                await _invoiceProductRepository.Create(invoiceProduct, cancellationToken);
            }
            else
            {
                //disable product and returning products to the warehouse
                var product = await _productRepository.GetById(auction.ProductId, cancellationToken);
                product.IsEnabled = false;
                product.Stock = product.Stock + auction.CountOfProducts;
                await _productRepository.Update(product, cancellationToken);
            }
        }
    }
}
