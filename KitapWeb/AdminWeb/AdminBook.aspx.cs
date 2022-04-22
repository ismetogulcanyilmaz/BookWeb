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
    public partial class AdminBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _bookService.GetAll().Data;
            GridView1.DataBind();
        }

        IBookService _bookService = new BookManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var bookId = Convert.ToInt32(e.CommandArgument);
            var bookToUpdate = _bookService.GetById(bookId).Data;

            tbx_UpdateId.Text = Convert.ToString(bookToUpdate.Id);
            tbx_UpdateCategoryId.Text = Convert.ToString(bookToUpdate.BookCategoryId);
            tbx_UpdateName.Text = bookToUpdate.Name;
            tbx_UpdateUnitPrice.Text = Convert.ToString(bookToUpdate.UnitPrice);
            tbx_UpdateUnitsInStock.Text = Convert.ToString(bookToUpdate.UnitsInStock);

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var BookCategoryId = Convert.ToInt32(e.CommandArgument);
            var bookToDelete = _bookService.GetById(BookCategoryId).Data;

            Delete(bookToDelete);

            GetAll();
        }

        public void Delete(Book books)
        {
            _bookService.Delete(books);
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = Convert.ToInt32(tbx_UpdateId.Text);
            book.BookCategoryId = Convert.ToInt32(tbx_UpdateCategoryId.Text);
            book.Name = tbx_UpdateName.Text;
            book.UnitPrice = Convert.ToInt16(tbx_UpdateUnitPrice.Text);
            book.UnitsInStock = Convert.ToInt16(tbx_UpdateUnitsInStock.Text);

            _bookService.Update(book);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookCategoryId = Convert.ToInt32(tbx_AddBookCategoryId.Text);
            book.Name = tbx_AddName.Text;
            book.UnitPrice = Convert.ToInt16(tbx_AddUnitPrice.Text);
            book.UnitsInStock = Convert.ToInt16(tbx_AddUnitsInStock.Text);

            _bookService.Add(book);
            GetAll();
        }
    }
}