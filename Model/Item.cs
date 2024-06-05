namespace Model
{
    public class Item
    {
        public static readonly string Insert = "INSERT INTO Item (Description) VALUES (@Description); SELECT CAST(SCOPE_IDENTITY() as int)";

        public int ItemId { get; set; }
        public string Description { get; set; }

        override public string ToString()
        {
            return $"ItemId......: {ItemId}\n" +
                   $"Description.: {Description}\n";
        }
    }
}