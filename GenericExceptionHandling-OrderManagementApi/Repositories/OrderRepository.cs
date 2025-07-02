using GenericExceptionHandling_OrderManagementApi.Models;

namespace GenericExceptionHandling_OrderManagementApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<Order> GetOrderAsync(int id)
        {
            await Task.Delay(100); // simulate database call

            if (id == 999)
            {
                throw new InvalidOperationException("Database connection failed.");
            }

            return new Order { Id = id, CustomerName = "Jane Doe", TotalAmount = 450.0 };
        }

       
    }
}
