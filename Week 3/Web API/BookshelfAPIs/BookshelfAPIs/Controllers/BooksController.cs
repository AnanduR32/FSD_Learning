using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookshelfAPIs.Models;
using System.Web.Http.Cors;

namespace BookshelfAPIs.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BooksController : ApiController
    {
        BooksDatabase db = new BooksDatabase();
        [HttpGet]
        public List<Book> GetBooks()
        {
            return db.Books;
        }
    }
}