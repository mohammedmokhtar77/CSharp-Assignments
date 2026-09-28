namespace Assign2Advanced;

public class OrderService
{
    public decimal CalculateOrderPrice(Order order, Func<Order, decimal> pricingStrategy)
    {
        return  pricingStrategy(order);
    }
    public event Action<Order>? OrderProcessed;

    public void ProcessOrder(Order order)
    {
        Console.WriteLine($"Processing Order {order.Id}...");
        Console.WriteLine($"Order {order.Id} processed successfully.");
        OrderProcessed?.Invoke(order);
    }
}