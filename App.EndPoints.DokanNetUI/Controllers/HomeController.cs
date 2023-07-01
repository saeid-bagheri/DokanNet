using App.Domain.Core.Entities;
using App.Domain.Core.Services.Application.Queries;
using App.Domain.Core.Services.Buyers.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetOpenAuctions _getOpenAuctions;
        private readonly IMapper _mapper;

        public HomeController(IGetOpenAuctions getOpenAuctions, IMapper mapper)
        {
            _getOpenAuctions = getOpenAuctions;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var homeVM = new HomeVM();
            _mapper.Map(await _getOpenAuctions.Execute(cancellationToken), homeVM.openAuctions);
            return View(homeVM);
        }





















        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}