using Controller;
using Model;

internal class Program
{
    private static void Main(string[] args)
    {
        Order order = new Order()
        {
            Id = 1,
            Description = "Order 1",
            Table = 1,
            Item = new Item()
            {
                Description = "Item 1"
            }
        };

        if (new OrderController().Insert(order))
        {
            Console.WriteLine("Order inserted successfully");
        }
        else
        {
            Console.WriteLine("Order insertion failed");
        }
    }
}