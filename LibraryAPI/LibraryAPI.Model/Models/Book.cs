namespace LibraryAPI.Model.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int BookStateId { get; set; }
        public BookState BookState { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public string Url { get; set; }
    }
}