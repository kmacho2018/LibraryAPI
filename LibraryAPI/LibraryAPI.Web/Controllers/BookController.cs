using LibraryAPI.Model.Models;
using LibraryAPI.Model.Repository;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace LibraryAPI.Web.Controllers
{
    [RoutePrefix("api/Book")]
    public class BookController : ApiController
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        //api/Book/
        public IEnumerable<Book> Get() => bookRepository.GetAll();

        [Route("{id}")]
        public Book GetById(int id) => bookRepository.GetBookById(id);

        [Route("{id}/page/{pageNumber}/{contentType}")]
        public HttpResponseMessage GetPage(int id, int pageNumber, string contentType) => bookRepository.GetPage(id, pageNumber, contentType);
    }
}