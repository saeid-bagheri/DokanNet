using App.Domain.AppService.Admins.Commands;
using App.Domain.AppService.Admins.Queries;
using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.AppServices.Sellers.Commands;
using App.Domain.Core.Services.Admins.Commands;
using App.Domain.Core.Services.Admins.Queries;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Buyers.Commands;
using App.Domain.Core.Services.Buyers.Queries;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Common.Queries;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.Domain.Service.Admins.Commands;
using App.Domain.Service.Admins.Queries;
using App.Domain.Service.Application.Queries;
using App.Domain.Service.Buyers.Commands;
using App.Domain.Service.Buyers.Queries;
using App.Domain.Service.Common.Commands;
using App.Domain.Service.Common.Queries;
using App.Domain.Service.Sellers.Commands;
using App.Domain.Service.Sellers.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service._IocConfigs
{
    public static class ServiceCollectionExtentions
    {
        public static void Add_Sevices(this IServiceCollection services)
        {
            //Common
            services.AddScoped<IGetCities, GetCities>();
            services.AddScoped<IGetCategories, GetCategories>();
            services.AddScoped<IUpdateProduct, UpdateProduct>();
            services.AddScoped<ICreateInvoice, CreateInvoice>();
            services.AddScoped<IGetLastPriceOfAuction, GetLastPriceOfAuction>();
            services.AddScoped<IAddImageToProduct, AddImageToProduct>();
            services.AddScoped<IReduceProductStock, ReduceProductStock>();
            services.AddScoped<IAddProductStock, AddProductStock>();
            services.AddScoped<ICalculateSiteCommissionPercent, CalculateSiteCommissionPercent>();

            //admins
            services.AddScoped<ICloseStore, CloseStore>();
            services.AddScoped<IConfirmComment, ConfirmComment>();
            services.AddScoped<IConfirmProduct, ConfirmProduct>();
            services.AddScoped<IDeleteProduct, DeleteProduct>();
            services.AddScoped<IDeleteUser, DeleteUser>();
            services.AddScoped<ILoginUser, LoginUser>();
            services.AddScoped<IRegisterUser, RegisterUser>();
            services.AddScoped<IUpdateStore, UpdateStore>();
            services.AddScoped<IUpdateUser, UpdateUser>();
            services.AddScoped<IGetComments, GetComments>();
            services.AddScoped<IGetProductById, GetProductById>();
            services.AddScoped<IGetProducts, GetProducts>();
            services.AddScoped<IGetStoreById, GetStoreById>();
            services.AddScoped<IGetStores, GetStores>();
            services.AddScoped<IGetUserById, GetUserById>();
            services.AddScoped<IGetUserRolesByHttp, GetUserRolesByHttp>();
            services.AddScoped<IGetUserRolesByUserName, GetUserRolesByUserName>();
            services.AddScoped<IGetUsers, GetUsers>();
            services.AddScoped<IGetInvoices, GetInvoices>();
            services.AddScoped<ICreateSeller, CreateSeller>();
            services.AddScoped<IAddRoleToUser, AddRoleToUser>();
            services.AddScoped<IEndOfAuction, EndOfAuction>();

            //sellers
            services.AddScoped<ICreateStore, CreateStore>();
            services.AddScoped<IGetSellerById, GetSellerById>();
            services.AddScoped<IUpdateSellerProfile, UpdateSellerProfile>();
            services.AddScoped<IGetProductsByStoreId, GetProductsByStoreId>();
            services.AddScoped<ICreateProduct, CreateProduct>();
            services.AddScoped<IAddCategory, AddCategory>();
            services.AddScoped<IGetAuctionsByStoreId, GetAuctionsByStoreId>();
            services.AddScoped<ICreateAuction, CreateAuction>();
            services.AddScoped<IGetAuctionProductsByStoreId, GetAuctionProductsByStoreId>();
            services.AddScoped<IIsExistProductInStoreByName, IsExistProductInStoreByName>();
            services.AddScoped<IUpdateMedal, UpdateMedal>();
            services.AddScoped<IGetSellerByProductId, GetSellerByProductId>();
            services.AddScoped<IGetInvoicesBySellerId, GetInvoicesBySellerId>();
            services.AddScoped<ISellerUpdateProduct, SellerUpdateProduct>();

            //buyers
            services.AddScoped<IGetOpenAuctions, GetOpenAuctions>();
            services.AddScoped<ICreateBid, CreateBid>();
            services.AddScoped<ILosingBidsInAuction, LosingBidsInAuction>();
            services.AddScoped<IGetNormalProducts, GetNormalProducts>();
            services.AddScoped<IGetBasketByBuyerId, GetBasketByBuyerId>();
            services.AddScoped<ICreateBasket, CreateBasket>();
            services.AddScoped<IAddProductToBasket, AddProductToBasket>();
            services.AddScoped<IGetCountOfBasketProductsByBuyerId, GetCountOfBasketProductsByBuyerId>();
            services.AddScoped<IReduceProductFromBasket, ReduceProductFromBasket>();
            services.AddScoped<IFinalizePurchase, FinalizePurchase>();
            services.AddScoped<IGetBuyerById, GetBuyerById>();
            services.AddScoped<IUpdateBuyer, UpdateBuyer>();
            services.AddScoped<IGetInvoicesByBuyerId, GetInvoicesByBuyerId>();
            services.AddScoped<IGetParentCategories, GetParentCategories>();
            services.AddScoped<IGetProductsForCategoryAndSubcategories, GetProductsForCategoryAndSubcategories>();
            services.AddScoped<IGetCategoryById, GetCategoryById>();
        }
    }
}
