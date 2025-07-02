using GenericExceptionHandling_OrderManagementApi.Models;

namespace GenericExceptionHandling_OrderManagementApi.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderAsync(int id);
    }
}
