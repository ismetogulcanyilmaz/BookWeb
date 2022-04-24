using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MenuAdminManager : IMenuAdminService
    {

        IMenuAdminDal _menuAdminDal;

        public MenuAdminManager()
        {
            _menuAdminDal = new EfMenuAdminDal();
        }

        public IResult Add(MenuAdmin menuAdmin)
        {
            _menuAdminDal.Add(menuAdmin);
            return new SuccessResult();
        }

        public IResult Delete(MenuAdmin menuAdmin)
        {
            _menuAdminDal.Delete(menuAdmin);
            return new SuccessResult();
        }

        public IDataResult<List<MenuAdmin>> GetAll()
        {
            var result = _menuAdminDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<MenuAdmin>>();
            }
            return new SuccessDataResult<List<MenuAdmin>>(result);
        }

        public IDataResult<MenuAdmin> GetById(int id)
        {
            var result = _menuAdminDal.Get(m => m.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<MenuAdmin>();
            }
            return new SuccessDataResult<MenuAdmin>(result);
        }

        public IResult Update(MenuAdmin menuAdmin)
        {
            _menuAdminDal.Update(menuAdmin);
            return new SuccessResult();
        }
    }
}
