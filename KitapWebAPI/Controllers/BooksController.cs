using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KitapWebAPI.Controllers
{
    public class BooksController : ApiController
    {
        IBookService _bookService;
        public BooksController()
        {
            _bookService = new BookManager();
        }

        [HttpGet]
        public List<Book> GetAll()
        {
            var result = _bookService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public Book GetById(int id)
        {
            var result = _bookService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(Book book)
        {
            var result = _bookService.Add(book);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(Book book)
        {
            var result = _bookService.Delete(book);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(Book book)
        {
            var result = _bookService.Update(book);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}