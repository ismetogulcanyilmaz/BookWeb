using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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
    public class EfCartDal : EfEntityRepositoryBase<Cart, KitapSatisContext>, ICartDal
    {
        public List<CartDto> GetAllCartDto(User user)
        {
            using (KitapSatisContext context = new KitapSatisContext())
            {
                var result = from book in context.Books
                             join cart in context.Carts
                             on book.Id equals cart.BookId
                             where cart.UserId == user.Id
                             select new CartDto
                             {
                                 BookName = book.Name,
                                 Quantity = cart.Quantity,
                                 UserName = user.FirstName + " " + user.LastName,
                                 BookUnitPrice = book.UnitPrice,
                                 BookId = book.Id,
                                 CartId = cart.Id,
                                 Photo = book.Photo,
                             };
                return result.ToList();
            }
        }
    }
}
