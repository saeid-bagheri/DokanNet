using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.AppServices.Sellers.Commands;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize(Roles = "SellerRole")]
    public class ProductController : Controller
    {
        private readonly IGetProductsByStoreId _getProductsByStore;
        private readonly IGetSellerById _getSellerById;
        private readonly IGetStoreById _getStoreById;
        private readonly IGetCategories _getCategories;
        private readonly ICreateProduct _createProduct;
        private readonly IAddImageToProduct _addImageToProduct;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductController(IGetProductsByStoreId getProductsByStore, IGetSellerById getSellerById,
                                 IMapper mapper, IWebHostEnvironment hostingEnvironment,
                                 IGetStoreById getStoreById, IGetCategories getCategories,
                                 ICreateProduct createProduct, IAddImageToProduct addImageToProduct)
        {
            _getProductsByStore = getProductsByStore;
            _getSellerById = getSellerById;
            _mapper = mapper;
            _getStoreById = getStoreById;
            _getCategories = getCategories;
            _createProduct = createProduct;
            _hostingEnvironment = hostingEnvironment;
            _addImageToProduct = addImageToProduct;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var products = _mapper.Map<List<SellerProductVM>>(await _getProductsByStore.Execute(id, cancellationToken));
            TempData["storeId"] = (await _getStoreById.Execute(id, cancellationToken)).Id;
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int id, CancellationToken cancellationToken)
        {
            var createProductVM = new SellerProductVM()
            {
                StoreId = (await _getStoreById.Execute(id, cancellationToken)).Id,
                Categories = await _getCategories.Execute(cancellationToken)
            };
            return View(createProductVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SellerProductVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                //create product
                var productId = await _createProduct.Execute(_mapper.Map<ProductDto>(model), cancellationToken);

                //add product image
                if (model.Image is not null)
                {
                    await _addImageToProduct.Execute(productId, model.Image, _hostingEnvironment.WebRootPath, cancellationToken);
                }
                return RedirectToAction("Index", new { id = model.StoreId });
            }
            return View(model);
        }

    }
}
