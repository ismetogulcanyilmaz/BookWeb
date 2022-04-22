using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapWeb.AdminWeb
{
    public partial class AdminBookCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _bookcategoryService.GetAll().Data;
            GridView1.DataBind();
        }

        IBookCategoryService _bookcategoryService = new BookCategoryManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var bookcategoryId = Convert.ToInt32(e.CommandArgument);
            var bookcategoryToUpdate = _bookcategoryService.GetById(bookcategoryId).Data;

            tbx_UpdateId.Text = Convert.ToString(bookcategoryToUpdate.Id);
            tbx_UpdateName.Text = bookcategoryToUpdate.Name;

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var bookcategoryId = Convert.ToInt32(e.CommandArgument);
            var bookcategoryToDelete = _bookcategoryService.GetById(bookcategoryId).Data;

            Delete(bookcategoryToDelete);

            GetAll();
        }

        public void Delete(BookCategory bookcategory)
        {
            _bookcategoryService.Delete(bookcategory);
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
            BookCategory bookcategory = new BookCategory();
            bookcategory.Id = Convert.ToInt32(tbx_UpdateId.Text);
            bookcategory.Name = tbx_UpdateName.Text;

            _bookcategoryService.Update(bookcategory);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            BookCategory bookcategory = new BookCategory();
            bookcategory.Name = tbx_AddName.Text;

            _bookcategoryService.Add(bookcategory);
            GetAll();
        }
    }
}