using Service;

namespace Controller
{
    public class OrderController
    {
        private readonly OrderService _orderService;

        public OrderController() => _orderService = new OrderService();

        public bool Insert(Model.Order order) => _orderService.Insert(order);
    }
}