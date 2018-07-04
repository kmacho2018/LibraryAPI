using LibraryAPI.Model.Models;
using LibraryAPI.Model.Repository;
using LibraryAPI.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraryAPI.Web.Tests.Controllers
{
    [TestClass]
    public class BookControllerTest
    {
        private readonly IBookRepository bookRepository;

        public BookControllerTest(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public BookControllerTest()
        {
            this.bookRepository = new BookRepository();
        }

        [TestMethod]
        public void Get()
        {
            // Arrange
            BookController controller = new BookController(this.bookRepository);

            // Act
            IEnumerable<Book> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            BookController controller = new BookController(this.bookRepository);

            // Act
            Book result = controller.GetById(1);

            // Assert
            Assert.AreEqual("Juan Salvador Gaviota", result.Name);
        }

        [TestMethod]
        public void GetPage()
        {
            // Arrange
            BookController controller = new BookController(this.bookRepository);

            // Act
            HttpResponseMessage result = controller.GetPage(1, 1, "html");
            var res = result.Content.Headers.ContentType;

            // Assert
            Assert.AreEqual(true, result.IsSuccessStatusCode);
            Assert.AreEqual(result.Content.Headers.ContentType.MediaType, "text/html");
        }

        [TestMethod]
        public void GetPage_Plain()
        {
            // Arrange
            BookController controller = new BookController(this.bookRepository);

            // Act
            HttpResponseMessage result = controller.GetPage(1, 1, "plain");
            var res = result.Content.Headers.ContentType;

            // Assert
            Assert.AreEqual(true, result.IsSuccessStatusCode);
            Assert.AreEqual(result.Content.Headers.ContentType.MediaType, "text/plain");
        }


        [TestMethod]
        public void GetPage_Xml()
        {
            // Arrange
            BookController controller = new BookController(this.bookRepository);

            // Act
            HttpResponseMessage result = controller.GetPage(1, 1, "xml");
            var res = result.Content.Headers.ContentType;

            // Assert
            Assert.AreEqual(true, result.IsSuccessStatusCode);
            Assert.AreEqual(result.Content.Headers.ContentType.MediaType, "text/xml");
        }

        [TestMethod]
        public async Task GetPage_UnsupportedFormat()
        {
            // Arrange
            BookController controller = new BookController(this.bookRepository);

            // Act
            HttpResponseMessage result = controller.GetPage(1, 1, "kjkjk");

            // Assert
            Assert.AreEqual(true, result.IsSuccessStatusCode);
            Assert.AreEqual(await result.Content.ReadAsStringAsync(), "Unsupported format");
        }
    }
}