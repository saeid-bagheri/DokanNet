using App.Domain.Core.Services.Common.Queries;
using App.EndPoints.DokanNetApi.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoints.DokanNetApi.Controllers.DokanNetUI
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : ControllerBase
    {
        private readonly IGetStores _getStores;

        public CommonController(IGetStores getStores)
        {
            _getStores = getStores;
        }

        [HttpGet("[action]")]
        [ApiKeyAuthorize]
        public async Task<IActionResult> GetStores(CancellationToken cancellationToken)
        {
            var stores = await _getStores.Execute(cancellationToken);
            return Ok(stores);
        }
    }
}
