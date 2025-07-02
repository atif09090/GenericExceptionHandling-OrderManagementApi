using GenericExceptionHandling_OrderManagementApi.Models;

namespace GenericExceptionHandling_OrderManagementApi.Services
{
    public interface IOrderService
    {
        Task<Order> GetOrderAsync(int id);
    }
}
