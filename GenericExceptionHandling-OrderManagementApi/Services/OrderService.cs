using GenericExceptionHandling_OrderManagementApi.Models;
using GenericExceptionHandling_OrderManagementApi.Repositories;

namespace GenericExceptionHandling_OrderManagementApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IOrderRepository repository, ILogger<OrderService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Order> GetOrderAsync(int id)
        {
            try
            {
                return await _repository.GetOrderAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to get order with ID {OrderId}", id);
                throw new ApplicationException("Unable to retrieve order. Please try again later.");
            }
        }
    }
}
