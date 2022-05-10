using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        IDataResult<List<Cart>> GetAll();
        IResult Add(Cart cart);
        IResult Delete(Cart cart);
        IResult Update(Cart cart);
        IDataResult<Cart> GetById(int id);

    }
}
