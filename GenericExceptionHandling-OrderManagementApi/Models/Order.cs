namespace GenericExceptionHandling_OrderManagementApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public double TotalAmount { get; set; }
    }
}
