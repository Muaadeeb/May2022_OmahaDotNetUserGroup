namespace DataAccess.Data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string AuthorFirstName { get; set; } = null!;
        public string AuthorLastName { get; set; } = null!;
        public int PrintLength { get; set; }
        public string Publisher { get; set; } = null!;
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; } = null!;
        public int ReviewRating { get; set; }
        public string Comments { get; set; } = null!;
        public double Price { get; set; }
    }
}
