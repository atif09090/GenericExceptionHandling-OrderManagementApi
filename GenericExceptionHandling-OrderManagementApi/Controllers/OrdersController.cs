using GenericExceptionHandling_OrderManagementApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericExceptionHandling_OrderManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IOrderService orderService, ILogger<OrdersController> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            try
            {
                var order = await _orderService.GetOrderAsync(id);
                return Ok(order);
            }
            catch (ApplicationException ex)
            {
                // Known application-level exception
                _logger.LogWarning(ex, "Handled application error for Order ID {OrderId}", id);

                var problem = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Unable to fetch order",
                    Detail = ex.Message
                };

                return StatusCode(problem.Status.Value, problem);
            }
            catch (Exception ex)
            {
                // Unexpected exception — log and return generic error
                _logger.LogError(ex, "Unexpected error for Order ID {OrderId}", id);

                var problem = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "Unexpected error",
                    Detail = "Please contact support with reference code: ERR-500"
                };

                return StatusCode(problem.Status.Value, problem);
            }
        }
    }
}
