using ToDoList2.Core.Common.Middlewares;

namespace ToDoList2.Core.Common.Extensions.ErrorHandler
{
    public static class ErrorHandlerExtension
    {
        public static void UseErrorMiddleware(this IApplicationBuilder application)
        {
            application.UseMiddleware<ErrorMiddleware>();
        }
    }
}


