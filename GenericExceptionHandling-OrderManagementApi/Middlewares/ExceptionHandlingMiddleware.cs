using Microsoft.AspNetCore.Mvc;

namespace GenericExceptionHandling_OrderManagementApi.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception occurred");

                var problem = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Unexpected error",
                    Detail = "Please contact support with reference ID: ERR-500"
                };

                context.Response.ContentType = "application/problem+json";
                context.Response.StatusCode = problem.Status.Value;

                await context.Response.WriteAsJsonAsync(problem);
            }
        }
    }

}
