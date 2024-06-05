using Model;

namespace Repository
{
    public interface IOrderRepository
    {
        bool Insert(Order order);

        List<Order> GetAll();
    }
}