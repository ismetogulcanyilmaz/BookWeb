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
    public class BookOrdersController : ApiController
    {
        IBookOrderService _bookOrderService;
        public BookOrdersController()
        {
            _bookOrderService = new BookOrderManager();
        }

        [HttpGet]
        public List<BookOrder> GetAll()
        {
            var result = _bookOrderService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public BookOrder GetById(int id)
        {
            var result = _bookOrderService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(BookOrder bookOrder)
        {
            var result = _bookOrderService.Add(bookOrder);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(BookOrder bookOrder)
        {
            var result = _bookOrderService.Delete(bookOrder);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(BookOrder bookOrder)
        {
            var result = _bookOrderService.Update(bookOrder);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}