using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GlobalExceptionHandling.Exception
{
    public class GlobalException : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var ex = context.Exception;
            context.Result = new OkObjectResult(new {errorDesc = ex.Message});
        }
    }
}
