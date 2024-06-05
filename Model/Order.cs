namespace Model
{
    public class Order
    {
        public static readonly string Insert = "INSERT INTO Orders (Description, OrderTable, ItemId) VALUES (@Description, @Table, @ItemId)";
        public static readonly string GetAll = "SELECT p.Id, p.Description, p.OrderTable, i.ItemId, i.Description From Orders p inner join Item i on p.ItemId = i.ItemId";

        public int Id { get; set; }
        public string Description { get; set; }
        public int Table { get; set; }
        public Item Item { get; set; }

        override public string ToString()
        {
            return $"Id..........: {Id}\n" +
                   $"Description.: {Description}\n" +
                   $"Table.......: {Table}\n" +
                   $"{Item}\n";
        }
    }
}