using App.Domain.AppService.Admins.Queries;
using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Admins.Commands;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Common.Commands;
using App.Domain.Core.Services.Common.Queries;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminRole")]
    public class ProductController : Controller
    {
        private readonly IGetProducts _getProducts;
        private readonly IGetProductById _getProductById;
        private readonly IUpdateProduct _updateProduct;
        private readonly IDeleteProduct _deleteProduct;
        private readonly IConfirmProduct _confirmProduct;
        private readonly IGetCategories _getCategories;
        private readonly IAddCategory _addCategory;
        private readonly IMapper _mapper;
        private readonly IAddImageToProduct _addImageToProduct;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductController(IGetProducts getProducts, IGetProductById getProductById,
                                 IMapper mapper, IUpdateProduct updateProduct,
                                 IDeleteProduct deleteProduct, IConfirmProduct confirmProduct,
                                 IGetCategories getCategories, IAddCategory addCategory,
                                 IAddImageToProduct addImageToProduct, IWebHostEnvironment hostingEnvironment)
        {
            _getProducts = getProducts;
            _getProductById = getProductById;
            _mapper = mapper;
            _updateProduct = updateProduct;
            _deleteProduct = deleteProduct;
            _confirmProduct = confirmProduct;
            _getCategories = getCategories;
            _addCategory = addCategory;
            _addImageToProduct = addImageToProduct;
            _hostingEnvironment = hostingEnvironment;
        }


        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var products = _mapper.Map<List<AdminProductVM>>(await _getProducts.Execute(cancellationToken));
            return View(products);
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<AdminProductVM>(await _getProductById.Execute(id, cancellationToken));
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(AdminProductVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateProduct.Execute(_mapper.Map<ProductDto>(model), cancellationToken);

                //add product image
                if (model.Image is not null)
                {
                    await _addImageToProduct.Execute(model.Id, model.Image, _hostingEnvironment.WebRootPath, cancellationToken);
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _deleteProduct.Execute(id, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Confirm(int id, CancellationToken cancellationToken)
        {
            await _confirmProduct.Execute(id, cancellationToken);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> AddCategory(CancellationToken cancellationToken)
        {
            var category = new AdminCategoryVM()
            {
                Categories = await _getCategories.Execute(cancellationToken)
            };
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(AdminCategoryVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _addCategory.Execute(_mapper.Map<CategoryDto>(model), _hostingEnvironment.WebRootPath, cancellationToken);
                return RedirectToAction("AddCategory");
            }
            return View(model);
        }

    }
}