using App.Domain.AppService.Admins.Queries;
using App.Domain.Core.AppServices.Admins.Commands;
using App.Domain.Core.AppServices.Admins.Queries;
using App.Domain.Core.DtoModels;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="AdminRole")]
    public class ProductController : Controller
    {
        private readonly IGetProducts _getProducts;
        private readonly IGetProductById _getProductById;
        private readonly IUpdateProduct _updateProduct;
        private readonly IDeleteProduct _deleteProduct;
        private readonly IConfirmProduct _confirmProduct;
        private readonly IMapper _mapper;

        public ProductController(IGetProducts getProducts, IGetProductById getProductById,
                                 IMapper mapper, IUpdateProduct updateProduct,
                                 IDeleteProduct deleteProduct, IConfirmProduct confirmProduct)
        {
            _getProducts = getProducts;
            _getProductById = getProductById;
            _mapper = mapper;
            _updateProduct = updateProduct;
            _deleteProduct = deleteProduct;
            _confirmProduct = confirmProduct;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var products = _mapper.Map<List<ProductVM>>(await _getProducts.Execute(cancellationToken));
            return View(products);
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<ProductVM>(await _getProductById.Execute(id, cancellationToken));
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductVM model, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                await _updateProduct.Execute(_mapper.Map<ProductDto>(model), cancellationToken);
            }
            return RedirectToAction("Index");
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

    }
}
