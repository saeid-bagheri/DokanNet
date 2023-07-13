using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Admins.Commands;
using App.Domain.Core.Services.Common.Commands;
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
        private readonly IProductRepository _productRepository;
        private readonly ICreateInvoice _createInvoice;

        public EndOfAuction(IAuctionRepository auctionRepository, ISellerRepository sellerRepository,
                            IProductRepository productRepository, ICreateInvoice createInvoice)
        {
            _auctionRepository = auctionRepository;
            _sellerRepository = sellerRepository;
            _productRepository = productRepository;
            _createInvoice = createInvoice;
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
                var invoiceDto = new InvoiceDto()
                {
                    TotalAmount = auction.Price,
                    BuyerId = winnerBid.BuyerId,
                    SellerId = seller.Id
                };

                //create invoiceProducts
                var invoiceProducts = new List<InvoiceProductDto>();
                invoiceProducts.Add(new InvoiceProductDto()
                {
                    ProductId = auction.ProductId,
                    CountOfProducts = auction.CountOfProducts
                });
                invoiceDto.InvoiceProducts = invoiceProducts;

                await _createInvoice.Execute(invoiceDto, cancellationToken);

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
