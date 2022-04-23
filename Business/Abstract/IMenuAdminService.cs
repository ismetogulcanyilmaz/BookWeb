using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMenuAdminService
    {
        IDataResult<List<MenuAdmin>> GetAll();
        IDataResult<MenuAdmin> GetById(int id);
        IResult Add(MenuAdmin menuAdmin);
        IResult Update(MenuAdmin menuAdmin);
        IResult Delete(MenuAdmin menuAdmin);
    }
}
