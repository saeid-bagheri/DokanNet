using App.Domain.Core.Services.Buyers.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetOpenAuctions _getOpenAuctions;
        private readonly IMapper _mapper;
        private readonly IGetNormalProducts _getNormalProducts;

        public HomeController(IGetOpenAuctions getOpenAuctions, IMapper mapper,
                              IGetNormalProducts getNormalProducts)
        {
            _getOpenAuctions = getOpenAuctions;
            _mapper = mapper;
            _getNormalProducts = getNormalProducts;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var homeVM = new HomeVM();

            //get open auctions
            _mapper.Map(await _getOpenAuctions.Execute(cancellationToken), homeVM.OpenAuctions);

            //get last 10 normal products
            _mapper.Map((await _getNormalProducts.Execute(cancellationToken)).Take(10), homeVM.NormalProducts);

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