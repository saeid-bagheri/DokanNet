using App.Domain.Core.Services.Sellers.Queries;
using App.EndPoints.DokanNetUI.Areas.Seller.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace App.EndPoints.DokanNetUI.Areas.Seller.Controllers
{
    [Area("Seller")]
    [Authorize(Roles = "SellerRole")]
    public class InvoiceController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetInvoicesBySellerId _getInvoicesBySellerId;

        public InvoiceController(IMapper mapper, IGetInvoicesBySellerId getInvoicesBySellerId)
        {
            _mapper = mapper;
            _getInvoicesBySellerId = getInvoicesBySellerId;
        }

        public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
        {
            var invoices = _mapper.Map<List<SellerInvoiceVM>>(await _getInvoicesBySellerId.Execute(id, cancellationToken));
            TempData["StoreId"] = id;
            return View(invoices);
        }
    }
}
