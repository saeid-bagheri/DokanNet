using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Commands;
using App.Domain.Core.Services.Buyers.Queries;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Common.Queries;
using App.Domain.Core.Services.Sellers.Queries;
using App.Domain.Service.Buyers.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace App.EndPoints.DokanNetUI.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        private readonly ICreateBasket _createBasket;
        private readonly IGetBasketByBuyerId _getBasketByBuyerId;
        private readonly IAddProductToBasket _addProductToBasket;
        private readonly IReduceProductFromBasket _reduceProductFromBasket;
        private readonly IReduceProductStock _reduceProductStock;
        private readonly IAddProductStock _addProductStock;
        private readonly IGetSellerByProductId _getSellerByProductId;
        private readonly IGetProductById _getProductById;
        private readonly ICreateInvoice _createInvoice;
        private readonly IFinalizePurchase _finalizePurchase;
        private readonly IMapper _mapper;

        public BasketController(IAddProductToBasket addProductToBasket, IGetBasketByBuyerId getBasketByBuyerId,
                                IGetSellerByProductId getSellerByProductId, ICreateBasket createBasket,
                                IReduceProductStock reduceProductStock, IMapper mapper,
                                IGetProductById getProductById, IReduceProductFromBasket reduceProductFromBasket,
                                IAddProductStock addProductStock, ICreateInvoice createInvoice,
                                IFinalizePurchase finalizePurchase)
        {
            _createBasket = createBasket;
            _getBasketByBuyerId = getBasketByBuyerId;
            _addProductToBasket = addProductToBasket;
            _reduceProductFromBasket = reduceProductFromBasket;
            _reduceProductStock = reduceProductStock;
            _addProductStock = addProductStock;
            _getSellerByProductId = getSellerByProductId;
            _getProductById = getProductById;
            _createInvoice = createInvoice;
            _mapper = mapper;
            _finalizePurchase = finalizePurchase;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var basket = await _getBasketByBuyerId.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);
            var basketVM = new BasketVM();
            _mapper.Map(basket, basketVM);
            return View(basketVM);
        }

        public async Task<IActionResult> AddToBasket(int id, CancellationToken cancellationToken)
        {
            //checking if the product is in stock
            if ((await _getProductById.Execute(id, cancellationToken)).Stock > 0)
            {

                var basket = await _getBasketByBuyerId.Execute(Convert.ToInt32(User.Identity.GetUserId()), cancellationToken);

                //this buyer has not basket
                if (basket is null)
                {
                    //create basket
                    var basketProductDto = new BasketProductDto()
                    {
                        ProductId = id,
                        CountOfProducts = 1,
                        BuyerId = Convert.ToInt32(User.Identity.GetUserId()),
                        SellerId = (await _getSellerByProductId.Execute(id, cancellationToken)).Id
                    };
                    await _createBasket.Execute(basketProductDto, cancellationToken);

                    //Reducing the number of stock products
                    await _reduceProductStock.Execute(basketProductDto.CountOfProducts, basketProductDto.ProductId, cancellationToken);

                    return RedirectToAction("Index", "Home");
                }

                //this buyer has basket
                else
                {
                    //checking that the seller is the same
                    if (basket.SellerId == (await _getSellerByProductId.Execute(id, cancellationToken)).Id)
                    {
                        //add product to basket
                        var basketProductDto = new BasketProductDto()
                        {
                            ProductId = id,
                            CountOfProducts = 1,
                            BuyerId = basket.BuyerId,
                            SellerId = basket.SellerId
                        };
                        await _addProductToBasket.Execute(basket, basketProductDto, cancellationToken);

                        //reducing the number of stock products
                        await _reduceProductStock.Execute(basketProductDto.CountOfProducts, basketProductDto.ProductId, cancellationToken);

                        //back tp pervious page
                        return Redirect(Request.Headers["Referer"].ToString());
                    }
                    else
                    {
                        TempData["SameSellerErrorMessage"] = "از دو غرفه به صورت همزمان نمیتوان خرید کرد";
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            //the stock of the product in the warehouse is 0
            else
            {
                TempData["ProductStockIsZeroErrorMessage"] = "محصول موجود نیست!";
                //back tp pervious page
                return Redirect(Request.Headers["Referer"].ToString());
            }


        }

        public async Task<IActionResult> ReduceFromBasket(int id, CancellationToken cancellationToken)
        {
            //reducing product from basket
            var basketProductDto = new BasketProductDto()
            {
                ProductId = id,
                CountOfProducts = 1,
                BuyerId = Convert.ToInt32(User.Identity.GetUserId()),
                SellerId = (await _getSellerByProductId.Execute(id, cancellationToken)).Id
            };
            await _reduceProductFromBasket.Execute(basketProductDto, cancellationToken);

            //adding the number of stock products
            await _addProductStock.Execute(basketProductDto.CountOfProducts, id, cancellationToken);

            return Redirect(Request.Headers["Referer"].ToString());
        }


        public async Task<IActionResult> FinalizePurchase(int id, CancellationToken cancellationToken)
        {
            var invoiceDto = await _getBasketByBuyerId.Execute(id, cancellationToken);
            await _finalizePurchase.Execute(invoiceDto, cancellationToken);
            return RedirectToAction("Index", "Home");
        }

    }
}
