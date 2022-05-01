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
    public class BookCategoriesController : ApiController
    {
        IBookCategoryService _bookCategoryService;
        public BookCategoriesController()
        {
            _bookCategoryService = new BookCategoryManager();
        }

        [HttpGet]
        public List<BookCategory> GetAll()
        {
            var result = _bookCategoryService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public BookCategory GetById(int id)
        {
            var result = _bookCategoryService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(BookCategory bookCategory)
        {
            var result = _bookCategoryService.Add(bookCategory);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(BookCategory bookCategory)
        {
            var result = _bookCategoryService.Delete(bookCategory);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(BookCategory bookCategory)
        {
            var result = _bookCategoryService.Update(bookCategory);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}