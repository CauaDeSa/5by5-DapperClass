using Model;
using Repository;

namespace Service
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService() => _orderRepository = new OrderRepository();

        public bool Insert(Order order) => _orderRepository.Insert(order);

        public List<Order> GetAll() => _orderRepository.GetAll();
    }
}