﻿using App.Domain.Core.AppServices.Sellers.Commands;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Common.Queries;
using App.Domain.Core.Services.Sellers.Commands;
using App.Domain.Core.Services.Sellers.Queries;
using App.Domain.Service.Common.Commands;
using App.Domain.Service.Common.Queries;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNet.Identity;
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
        private readonly IGetCategories _getCategories;
        private readonly ICreateProduct _createProduct;
        private readonly IAddImageToProduct _addImageToProduct;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IIsExistProductInStoreByName _isExistProductInStoreByName;
        private readonly IGetProductById _getProductById;
        private readonly ISellerUpdateProduct _sellerUpdateProduct;

        public ProductController(IGetProductsByStoreId getProductsByStore, IMapper mapper,
                                 IWebHostEnvironment hostingEnvironment, IGetCategories getCategories,
                                 ICreateProduct createProduct, IAddImageToProduct addImageToProduct,
                                 IIsExistProductInStoreByName isExistProductInStoreByName, IGetProductById getProductById,
                                 ISellerUpdateProduct sellerUpdateProduct)
        {
            _getProductsByStore = getProductsByStore;
            _mapper = mapper;
            _getCategories = getCategories;
            _createProduct = createProduct;
            _hostingEnvironment = hostingEnvironment;
            _addImageToProduct = addImageToProduct;
            _isExistProductInStoreByName = isExistProductInStoreByName;
            _getProductById = getProductById;
            _sellerUpdateProduct = sellerUpdateProduct;
        }



        [HttpGet]
        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var products = _mapper.Map<List<SellerProductVM>>(await _getProductsByStore.Execute(id, cancellationToken));
            TempData["StoreId"] = id;
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create(int id, CancellationToken cancellationToken)
        {
            var sellerProductVM = new SellerProductVM()
            {
                StoreId = id,
                Categories = await _getCategories.Execute(cancellationToken)
            };
            return View(sellerProductVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SellerProductVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                //check product is exist in store
                var isExist = await _isExistProductInStoreByName.Execute(model.Title, model.StoreId, cancellationToken);
                if (isExist)
                {
                    ModelState.AddModelError(string.Empty, "محصول با این نام در غرفه موجود است");
                }
                else
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
            }
            model.Categories = await _getCategories.Execute(cancellationToken);
            return View(model);
        }


        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<SellerProductVM>(await _getProductById.Execute(id, cancellationToken));
            product.Categories = await _getCategories.Execute(cancellationToken);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SellerProductVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _sellerUpdateProduct.Execute(_mapper.Map<ProductDto>(model), cancellationToken);

                //add product image
                if (model.Image is not null)
                {
                    await _addImageToProduct.Execute(model.Id, model.Image, _hostingEnvironment.WebRootPath, cancellationToken);
                }
                return RedirectToAction("Index", new { id = model.StoreId });
            }
            return View(model);
        }

    }
}
