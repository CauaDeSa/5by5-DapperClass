using System.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using Model;

namespace Repository
{
    public class ItemRepository : IItemRepository
    {
        private string ConnectionString { get; set; }

        public ItemRepository() => ConnectionString = ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString;

        public int Insert(Item item)
        {
            var idItem = 0;

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                idItem = connection.ExecuteScalar<int>(Item.Insert, item);
                connection.Close();
            }

            return idItem;
        }
    }
}