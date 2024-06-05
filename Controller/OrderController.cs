using Model;
using Service;

namespace Controller
{
    public class OrderController
    {
        private readonly OrderService _orderService;

        public OrderController() => _orderService = new OrderService();

        public bool Insert(Order order)
        {
            order.Item.ItemId = new ItemService().Insert(order.Item);

            return _orderService.Insert(order);
        } 

        public List<Order> GetAll() => _orderService.GetAll();
    }
}