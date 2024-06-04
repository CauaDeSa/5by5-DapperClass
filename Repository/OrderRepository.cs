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

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute(Order.Insert, new{ Description = order.Description, Table = order.Table, ItemId = order.Item.Id});

                status = true;
            }

            return status;
        }
    }
}