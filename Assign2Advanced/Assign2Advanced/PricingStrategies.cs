namespace Assign2Advanced;

public static class PricingStrategies
{
    // Normal pricing
    public static decimal CalculateNormalPrice(Order order)
        => order.Price * order.Quantity;
    
    // 10% discount
    public static decimal CalculatePriceWith10PercentDiscount(Order order)
    {
        decimal total = order.Price * order.Quantity;
        return total * 0.90m;
    }

    // 20% discount
    public static decimal CalculatePriceWith20PercentDiscount(Order order)
    {
        decimal total = order.Price * order.Quantity;
        return total * 0.80m;
    }

    // VIP pricing - 30% discount
    public static decimal CalculateVipPrice(Order order)
    {
        decimal total = order.Price * order.Quantity;
        return total * 0.70m;
    }
}