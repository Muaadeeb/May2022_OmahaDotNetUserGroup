namespace ViewModels
{
    public class BookDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Please enter the author's first name")]
        public string AuthorFirstName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter the author's last name")]
        public string AuthorLastName { get; set; } = null!;

        public int PrintLength { get; set; }

        public string Publisher { get; set; } = null!;

        public string ISBN { get; set; }

        [Range(1, 10, ErrorMessage = "Rate between 1 (low) and 10 (high)")]
        public int ReviewRating { get; set; }

        public string Comments { get; set; } = null!;
        public bool IsActive { get; set; }

        public double Price { get; set; }
    }
}
