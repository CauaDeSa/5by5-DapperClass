using System.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using Model;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        private string ConnectionString { get; set; }

        public OrderRepository() => ConnectionString = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;

        public bool Insert(Order order)
        {
            var status = false;

            using var connection = new SqlConnection(ConnectionString);
            
                connection.Open();
                connection.Execute(Order.Insert, new{ order.Description, order.Table, order.Item.ItemId});

                status = true;
            
            return status;
        }

        public List<Order> GetAll()
        {
            List<Order> orders = new List<Order>();

            using var connection = new SqlConnection(ConnectionString);
            
                connection.Open();
                orders = connection.Query<Order, Item, Order>(Order.GetAll, (order, item) =>
                {
                    order.Item = item;
                    return order;
                }, splitOn: "ItemId").ToList();

            return orders;
        }
    }
}