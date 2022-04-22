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
    public partial class AdminBookOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _bookorderService.GetAll().Data;
            GridView1.DataBind();
        }

        IBookOrderService _bookorderService = new BookOrderManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var bookorderId = Convert.ToInt32(e.CommandArgument);
            var bookorderToUpdate = _bookorderService.GetById(bookorderId).Data;

            tbx_UpdateId.Text = Convert.ToString(bookorderToUpdate.Id);
            tbx_UpdateCustomerId.Text = Convert.ToString(bookorderToUpdate.CustomerId);
            tbx_UpdateBookId.Text = Convert.ToString(bookorderToUpdate.BookId);

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var BookOrderId = Convert.ToInt32(e.CommandArgument);
            var bookorderToDelete = _bookorderService.GetById(BookOrderId).Data;

            Delete(bookorderToDelete);

            GetAll();
        }

        public void Delete(BookOrder bookorder)
        {
            _bookorderService.Delete(bookorder);
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
            BookOrder bookorder = new BookOrder();
            bookorder.Id = Convert.ToInt32(tbx_UpdateId.Text);
            bookorder.CustomerId = Convert.ToInt32(tbx_UpdateCustomerId.Text);
            bookorder.BookId = Convert.ToInt32(tbx_UpdateBookId.Text);


            _bookorderService.Update(bookorder);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            BookOrder bookorder = new BookOrder();
            bookorder.CustomerId = Convert.ToInt32(tbx_AddCustomerId.Text);
            bookorder.BookId = Convert.ToInt32(tbx_UpdateBookId.Text);


            _bookorderService.Add(bookorder);
            GetAll();
        }
    }
}
