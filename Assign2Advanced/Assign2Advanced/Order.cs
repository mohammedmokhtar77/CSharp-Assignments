namespace Assign2Advanced;

public delegate decimal PriceCalculator(Order order); 

public class Order
{
    public int Id { get; set; } 
    
    public string CustomerName { get; set; } 
    
    public decimal Price { get; set; } 
    
    public int Quantity { get; set; } 
}