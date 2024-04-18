namespace InspirinngQuotes_Test_1.Models
{
    public class Tags
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
        public string Quote { get; set; }
        public string Action { get; set; }

    }
    public class TagInputModel
    {
        public int Id { get; set; }
        public string tags { get; set; }
    }
    public class QuotesInputModel
    {
        public int Id { get; set; }
        public string quotes { get; set; }
    }
}
