using LibraryAPI.Model.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace LibraryAPI.Model.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book GetBookById(int id);

        Book GetBookById(int id,string url);

        BookPage GetBookPage(int id, int pageNumber, string contentType);

        HttpResponseMessage GetPage(int id, int pageNumber, string contentType);
    }
}