using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, KitapSatisContext>, IBookDal
    {
        public List<BookDto> GetBookDtos()
        {
            using (var context = new KitapSatisContext())
            {
                var result = from book in context.Books
                             join bookCategory in context.BookCategories
                             on book.BookCategoryId equals bookCategory.Id
                             select new BookDto
                             {
                                 Id=book.Id,
                                 BookCategoryName = bookCategory.Name,
                                 BooksPage = book.BooksPage,
                                 Name = book.Name,
                                 UnitPrice = book.UnitPrice,
                                 UnitsInStock = book.UnitsInStock,
                                 WriterName = book.WriterName,

                             };
                return result.ToList();
            }
        }
    }
}
