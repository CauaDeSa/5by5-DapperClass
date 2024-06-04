namespace Model
{
    public class Order
    {
        public static readonly string Insert = "INSERT INTO Orders (Description, OrderTable, ItemId) VALUES (@Description, @Table, @ItemId)";

        public int Id { get; set; }
        public string Description { get; set; }
        public int Table { get; set; }
        public Item Item { get; set; }
    }
}