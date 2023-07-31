using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Drawing.Text;

namespace App.EndPoints.DokanNetApi.Attributes
{
    public class ApiKeyAuthorizeAttribute : Attribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "ApiKey";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME, out var extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "این کلید وجود ندارد"
                };
                return;
            }

            var appSetting = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSetting.GetSection(APIKEYNAME);

            if (apiKey.Value != extractedApiKey)
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "این ApiKey نامعتبر است"
                };
                return;
            }

            await next();
        }
    }
}
