namespace Assign2Advanced;

public class OrderEventHandlers
{
    public static void PrintOrderProcessed(Order order)
        => Console.WriteLine($"Order {order.Id} has been processed.");

    public static void SendOrderNotification(Order order)
        => Console.WriteLine($"Notification sent for Order {order.Id}.");
    
    public static void WriteOrderAudit(Order order)
        => Console.WriteLine($"AUDIT: Order {order.Id} was processed.");
    
}