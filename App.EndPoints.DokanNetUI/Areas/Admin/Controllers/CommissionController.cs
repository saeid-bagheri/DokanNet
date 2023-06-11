using App.Domain.Core.Services.Admins.Queries;
using App.EndPoints.DokanNetUI.Areas.Admin.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "AdminRole")]
    public class CommissionController : Controller
    {
        private readonly IGetInvoices _getInvoices;
        private readonly IMapper _mapper;

        public CommissionController(IGetInvoices getInvoices, IMapper mapper)
        {
            _getInvoices = getInvoices;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var invoices = _mapper.Map<List<InvoiceVM>>(await _getInvoices.Execute(cancellationToken));
            return View(invoices);
        }
    }
}
