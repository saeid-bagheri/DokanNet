namespace App.EndPoints.DokanNetUI.CustomMiddleWares
{
    public class CustomExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                // مدیریت استثناها
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            // کد خطا را اینجا قرار دهید
            // برای مثال، می‌توانید یک پاسخ خطا به مشتری برگردانید
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;
            return context.Response.WriteAsync($"{{ \"error\": \"{ex.Message}\" }}");
        }


    }
}
