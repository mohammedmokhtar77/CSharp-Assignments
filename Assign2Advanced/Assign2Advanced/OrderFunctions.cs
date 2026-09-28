namespace Assign2Advanced;

public class OrderFunctions
{
    public static decimal CalculateTotal(Order order)
    {
        return order.Price * order.Quantity;
    }

    public static decimal CalculateTotalWithDiscount(Order order)
    {
        decimal total = order.Price * order.Quantity;
        decimal discount = 100;
        return total - discount;
    }

    public static decimal CalculateOrderPriceUserDefined(Order order, PriceCalculator calculator)
    {
        return calculator(order);
    }
    public static decimal CalculateOrderPriceFunc(Order order, Func<Order, decimal> calculator)
    {
        return calculator(order);
    }
}