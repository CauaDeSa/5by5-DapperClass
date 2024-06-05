using Controller;
using Model;

internal class Program
{
    private static void Main(string[] args)
    {
        //Order order = new Order()
        //{
        //    Id = 1,
        //    Description = "Pizza combo",
        //    Table = 3,
        //    Item = new Item()
        //    {
        //        Description = "Chicken pizza"
        //    }
        //};

        //if (new OrderController().Insert(order))
        //{
        //    Console.WriteLine("Order inserted successfully");
        //}
        //else
        //{
        //    Console.WriteLine("Order insertion failed");
        //}

        new OrderController().GetAll().ForEach(order => Console.WriteLine(order));
    }
}