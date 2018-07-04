using LibraryAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LibraryAPI.Model.Repository
{
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// Method that is responsible for loading all the books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetAll()
        {
            using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDbContextCon"].ConnectionString))
            {
                Connection.Open();
                var SqlCommand = new SqlCommand(ConfigurationManager.AppSettings["GetAllBooks"], Connection);
                {
                    var reader = SqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        yield return new Book()
                        {
                            BookId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            AutorId = reader.GetInt32(4),
                            BookStateId = reader.GetInt32(5),
                            BookState = new BookState
                            {
                                StateName = reader.GetString(2),
                                BookStateId = reader.GetInt32(5),
                                StateDescription = reader.GetString(6)
                            },
                            Autor = new Autor()
                            {
                                Name = reader.GetString(3),
                                AutorId = reader.GetInt32(4)
                            }
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Method that is responsible for load a book by Id
        /// </summary>
        /// <param name="id">BookId</param>
        /// <returns></returns>
        public virtual Book GetBookById(int id)
        {
            using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDbContextCon"].ConnectionString))
            {
                Connection.Open();
                var SqlCommand = new SqlCommand(String.Format(ConfigurationManager.AppSettings["GetAllBooksById"], id), Connection);
                {
                    var reader = SqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        return new Book()
                        {
                            BookId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            AutorId = reader.GetInt32(4),
                            BookStateId = reader.GetInt32(5),
                            BookState = new BookState
                            {
                                StateName = reader.GetString(2),
                                BookStateId = reader.GetInt32(5),
                                StateDescription = reader.GetString(6)
                            },
                            Autor = new Autor()
                            {
                                Name = reader.GetString(3),
                                AutorId = reader.GetInt32(4)
                            }
                        };
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// Method that is responsible for searching books by Id and at the same time for online services
        /// </summary>
        /// <param name="id">BookId</param>
        /// <param name="url">Online Service URL</param>
        /// <returns></returns>
        public Book GetBookById(int id, string url)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id">BookId</param>
        /// <param name="pageNumber">Book PageNumber</param>
        /// <param name="contentType">Support content-type html|xml|plain</param>
        /// <returns></returns>
        public virtual BookPage GetBookPage(int id, int pageNumber, string contentType)
        {
            using (var Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LibraryDbContextCon"].ConnectionString))
            {
                Connection.Open();
                var SqlCommand = new SqlCommand(String.Format(ConfigurationManager.AppSettings["GetPage"], id, pageNumber, contentType), Connection);
                {
                    var reader = SqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        return new BookPage()
                        {
                            BookPageId = reader.GetInt32(0),
                            BookId = reader.GetInt32(1),
                            PageNumber = reader.GetInt32(2),
                            Content = reader.GetString(3)
                        };
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// Method that is responsible for loading a page of a book by id, by page number and format specified by the client
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageNumber"></param>
        /// <param name="contentType">Support content-type html|xml|plain</param>
        /// <returns></returns>
        public virtual HttpResponseMessage GetPage(int id, int pageNumber, string contentType)
        {
            BookPage bookPage = GetBookPage(id, pageNumber, contentType);

            var response = new HttpResponseMessage();

            string PageContent = (bookPage == null ? "Doesn't exist." : bookPage.Content);

            switch (contentType)
            {
                case "html":
                    PageContent = "<h3>" + PageContent + "</h3>";
                    break;

                case "xml":
                    PageContent = "<Page><Content>" + PageContent + "</Content></Page>";
                    break;

                case "plain":
                    break;

                default:
                    PageContent = "Unsupported format";
                    break;
            }

            response.Content = new StringContent(PageContent);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/" + contentType);

            return response;
        }
    }
}