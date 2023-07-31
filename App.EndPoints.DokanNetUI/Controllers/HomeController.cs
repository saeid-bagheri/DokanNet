using App.Domain.Core.DtoModels;
using App.Domain.Core.Services.Buyers.Queries;
using App.Domain.Core.Services.Common.Queries;
using App.EndPoints.DokanNetUI.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace App.EndPoints.DokanNetUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGetOpenAuctions _getOpenAuctions;
        private readonly IGetNormalProducts _getNormalProducts;
        private readonly IGetParentCategories _getParentCategories;
        private readonly IGetStores _getStores;
        private readonly IConfiguration _configuration;

        public HomeController(IGetOpenAuctions getOpenAuctions, IMapper mapper,
                              IGetNormalProducts getNormalProducts, IGetParentCategories getParentCategories,
                              IGetStores getStores, IConfiguration configuration)
        {
            _mapper = mapper;
            _getOpenAuctions = getOpenAuctions;
            _getNormalProducts = getNormalProducts;
            _getParentCategories = getParentCategories;
            _getStores = getStores;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var homeVM = new HomeVM();

            //get open auctions
            _mapper.Map(await _getOpenAuctions.Execute(cancellationToken), homeVM.OpenAuctions);

            //get last 10 normal products
            _mapper.Map((await _getNormalProducts.Execute(cancellationToken)).Take(10), homeVM.NormalProducts);

            //get parent categories
            ViewBag.categories = _mapper.Map((await _getParentCategories.Execute(cancellationToken)), homeVM.ParentCategories);

            ////get stores from service
            //_mapper.Map((await _getStores.Execute(cancellationToken)), homeVM.Stores);
             
            //get stores from api
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7065/api/Common/GetStores");
            request.Headers.Add("ApiKey", _configuration.GetSection("ApiKey").Value);

            var response = await client.SendAsync(request, cancellationToken);
            var responseBody = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("خطای دریافت از api");
            }
            else
            {
                var responseModel = JsonConvert.DeserializeObject<List<StoreDto>>(responseBody);
                _mapper.Map(responseModel, homeVM.Stores);
            }

            return View(homeVM);
        }


        public async Task<IActionResult> ProductList(CancellationToken cancellationToken)
        {
            var homeVM = new HomeVM();
            //get all products
            _mapper.Map((await _getNormalProducts.Execute(cancellationToken)), homeVM.NormalProducts);
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