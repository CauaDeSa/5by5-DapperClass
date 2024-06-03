using Dapper;
using Microsoft.Data.SqlClient;
using Model;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        private string ConnectionString { get; set; }

        public OrderRepository() => ConnectionString = "Data Source=127.0.0.1; Initial Catalog=DBOrder; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes";

        public bool Insert(Order order)
        {
            var status = false;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute(Order.Insert, order);

                status = true;
            }

            return status;
        }
    }
}