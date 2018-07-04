namespace LibraryAPI.Model.Models
{
    public class BookPage
    {
        public int BookPageId { get; set; }
        public int BookId { get; set; }
        public int PageNumber { get; set; }
        public string Content { get; set; }
    }
}