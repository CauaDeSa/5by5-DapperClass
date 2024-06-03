namespace Model
{
    public class Order
    {
        public static readonly string Insert = "INSERT INTO Orders (Description, OrderTable) VALUES (@Description, @Table)";

        public int Id { get; set; }
        public string Description { get; set; }
        public int Table { get; set; }
    }
}