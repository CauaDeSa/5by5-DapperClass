namespace Model
{
    public class Item
    {
        public static readonly string Insert = "INSERT INTO Item (Description) VALUES (@Description); SELECT CAST(SCOPE_IDENTITY() as int)";

        public int Id { get; set; }
        public string Description { get; set; }
    }
}