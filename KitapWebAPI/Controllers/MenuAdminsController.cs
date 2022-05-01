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
    public class MenuAdminsController : ApiController
    {
        IMenuAdminService _menuAdminService;
        public MenuAdminsController()
        {
            _menuAdminService = new MenuAdminManager();
        }

        [HttpGet]
        public List<MenuAdmin> GetAll()
        {
            var result = _menuAdminService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public MenuAdmin GetById(int id)
        {
            var result = _menuAdminService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(MenuAdmin menuAdmin)
        {
            var result = _menuAdminService.Add(menuAdmin);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(MenuAdmin menuAdmin)
        {
            var result = _menuAdminService.Delete(menuAdmin);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(MenuAdmin menuAdmin)
        {
            var result = _menuAdminService.Update(menuAdmin);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}